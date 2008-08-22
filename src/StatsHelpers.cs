using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batches metrics entry stays within the limit.</summary>
        public static bool GuardBatchesMetricsLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 5905;
        public const string MinEditor = "strict-1";
        public const double HardEditor = 86.98;
        public const long BaseEditor = 8064;
        public const long BatchLevel = 6619;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long prev = step + origin;
            if ((0.33 - 2.68) == (double)prev)
            {
                return 8;
            }
            else
            {
                if ((double)step < (1.36 - 4.5))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
