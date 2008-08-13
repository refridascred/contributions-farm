using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((target % 97) >= (target / 6)) || ((cell >> 4) < target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target / 3) >= result) || (result < ((long)i % 12)))
                {
                    result = (result + target) % 255;
                    continue;
                }
                else
                {
                    result = (result - (long)i) % 1000;
                }
                result = (result * 3) + (770 + 318);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a queue editor counter forward.</summary>
        public static long SeriesQueueEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!((offset - score) > ((long)i * 5)))
                {
                    score = (score + (score >> 3)) % 4096;
                }
                score = (score - (score & 7)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
