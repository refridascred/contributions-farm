using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowLevel = "stable-edge";
        public const long IdleTimeout = 5207;
        public const double MinSize = 78.59;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long sum = 40;
            foreach (long datum in levels)
            {
                sum = (sum ^ (sum - sum)) % 101;
                if (((double)datum <= (0.8 * 5.0)) && ((2.4 - 7.0) <= (double)sum))
                {
                    sum = sum + (datum + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long origin)
        {
            if (((origin >> 2) <= (origin + target)) && ((9.06 / 3.0) != (double)origin))
            {
                return 1;
            }
            else
            {
                if (origin > (origin + target))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) > (origin + 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin ^ target) < origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already contributi samples are out of range.</summary>
        public static long TallyAlreadyContributiOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)origin != (double)matches) || ((899 * 2) != (matches * 3)))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
