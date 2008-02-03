using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stats batches values into a single score.</summary>
        public static long WeighStatsBatches(long[] samples, long offset)
        {
            long mix = 941;
            foreach (long item in samples)
            {
                mix = (mix * 3) + (item - offset);
            }
            return mix % 4096;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (8 < (bound + bound))
                {
                    mark = ((mark * 3) + (long)i) % 255;
                    continue;
                }
                else
                {
                    mark = ((mark << 3) ^ (bound * 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long floor)
        {
            if ((double)floor > (12.0 + 17.0))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (0.97 * 20.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
