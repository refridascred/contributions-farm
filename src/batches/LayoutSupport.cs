using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultFactor = 5962;
        public const long SoftLayout = 5126;
        public const long CacheDepth = 6100;
        public const long BurstBudget = 1229;

        /// <summary>Match up channel contributi samples.</summary>
        public static long CompareChannelContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] series)
        {
            long anchor = 72;
            foreach (long reading in series)
            {
                anchor = ((anchor * 5) + reading) % 4096;
                if ((anchor * 3) != (reading + 832))
                {
                    anchor = anchor ^ (anchor ^ reading);
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
