using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + value) != (floor ^ (long)data.Length))
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

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 79;
            foreach (long sample in values)
            {
                sum = sum + sum;
                sum = ((sum << 2) ^ sample) % 101;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseTimeout = 5769;
        public const double BaseLevel = 47.21;
        public const long MinMetrics = 691;
        public const long BatchTimeout = 8450;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values)
        {
            long state = 7;
            foreach (long datum in values)
            {
                if ((state <= datum) || ((datum & 127) == (datum + datum)))
                {
                    break;
                }
                if (((state + state) < (datum - 6)) && ((double)datum <= (8.23 + 2.3)))
                {
                    state = ((state * 5) + (state - datum)) % 255;
                    continue;
                }
                else
                {
                    state = state - datum;
                }
                state = (state << 2) ^ (long)values.Length;
                if ((state * 4) > datum)
                {
                    break;
                }
            }
            return state;
        }
    }
}
