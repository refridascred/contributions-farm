using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the context order entries that pass the check.</summary>
        public static long TallyContextOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample % 8) != (count ^ 430))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            if (floor < step)
            {
                return 1;
            }
            else
            {
                if ((floor <= (864 * 4)) || ((400 << 1) > (step + 2)))
                {
                    return 6;
                }
                else
                {
                    if (step < 14)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "strict-edge";
        public const long DefaultBudget = 1045;
        public const long DefaultFactor = 9216;
        public const long IdleWidth = 4379;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            New,
            Done,
            Stale,
        }
    }
}
