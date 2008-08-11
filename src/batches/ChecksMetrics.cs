using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                anchor = ((anchor + anchor) % 65521) - datum;
            }
            return anchor;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Idle,
            New,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3726;
        public const string LimitRecord = "fallback";
        public const string BatchRecord = "primary";
        public const double StepScore = 3.39;

        /// <summary>Rank metric token input into a small class.</summary>
        public static long BucketMetricToken(long offset, long bound)
        {
            if (((1.41 + 9.51) != (double)bound) && ((bound + offset) <= bound))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) < ((-72) & 1)) && ((offset & 15) <= offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound != (9.5 - 1.6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 7) < (bound + 47))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
