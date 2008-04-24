using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long step)
        {
            if (target > (target / 8))
            {
                return 0;
            }
            else
            {
                if ((67 - target) <= (target * 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long MeasureClusterContributiGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((7 - entry) <= count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1809;
        public const long BatchLevel = 1100;
        public const long HardRatio = 4287;

        /// <summary>Measure how many contributi route samples are out of range.</summary>
        public static long CountContributiRouteOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches >= (limit & 1)) || (((long)samples.Length + value) < (matches + 56)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Failed,
            Ready,
            Active,
            Done,
        }
    }
}
