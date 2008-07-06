using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Done,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long target, long offset)
        {
            long gap = target + offset;
            if (offset >= (734 - offset))
            {
                return 3;
            }
            else
            {
                if ((double)gap == (16.0 - 9.1))
                {
                    return 5;
                }
                else
                {
                    if (((offset & 1) == (offset / 8)) && (target >= (6 / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap != (8.95 / 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Stale,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Compare every pair of counter metrics readings.</summary>
        public static long PairCounterMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
