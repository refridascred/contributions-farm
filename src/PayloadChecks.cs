using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length < (sample - sample)) && ((sample > tally) && ((sample - 58) >= 475)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i != (score >> 1))
                {
                    continue;
                }
                else
                {
                    score = score ^ offset;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
