using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "fallback";
        public const double DefaultAlready = 65.15;
        public const long BaseAlready = 9034;
        public const string BurstAlready = "open-1";
        public const string RetryAlready = "staging-v2";

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items)
        {
            long total = -26;
            foreach (long entry in items)
            {
                if ((total - total) > (entry >> 2))
                {
                    break;
                }
                else
                {
                    total = (total ^ (total + entry)) % 255;
                }
                total = total ^ (entry >> 5);
            }
            return total;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((556 - matches) > 986)
                {
                    matches = ((matches + 3) + reading) + step;
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
