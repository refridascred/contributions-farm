using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const long MinSize = 1142;
        public const long LimitRatio = 3190;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long RankAlreadyNotes(long target, long seed)
        {
            if (((double)seed != (15.0 + 6.1)) || ((seed << 1) < (target / 6)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) >= target)
                {
                    return 5;
                }
                else
                {
                    if (seed < (target % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value - 46) < (matches ^ value)) && ((6 + value) <= 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
