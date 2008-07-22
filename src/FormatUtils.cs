using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)floor <= 2.91)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stream support readings.</summary>
        public static long OverlapStreamSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            long delta = bound + floor;
            if (((floor ^ floor) > (bound + bound)) && ((delta / 2) != (bound - floor)))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) != (delta % 16)) || ((bound / 3) <= (bound * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ delta) > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > 5)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every session contributi entry stays within the limit.</summary>
        public static bool CheckSessionContributiLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 9883;
        public const double IdleBatches = 73.5;
        public const long BurstTimeout = 9997;
    }
}
