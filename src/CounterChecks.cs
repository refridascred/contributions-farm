using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleTimeout = 1775;
        public const string DefaultTimeout = "standard";
        public const long BaseBatch = 5623;
        public const long LimitBatch = 2962;
        public const string MinDepth = "alpha";

        /// <summary>Define context limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const long LimitLevel = 4638;
        public const long DefaultContext = 7301;
        public const long WindowContext = 6737;
        public const long LimitContext = 501;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine metrics report values into a single score.</summary>
        public static long DigestMetricsReport(long[] series)
        {
            long anchor = 97;
            foreach (long item in series)
            {
                anchor = ((anchor ^ (anchor >> 4)) % 97) + item;
            }
            if (anchor > 534)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 44.52;
        public const long LimitWidth = 8649;
        public const long StepBudget = 8829;
        public const long DefaultCluster = 999;

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardBudget = 8798;
        public const double StepLevel = 66.9;
        public const string CacheSpan = "strict";
        public const long BurstBudget = 4132;
        public const string MaxChannel = "latest-edge";
    }
}
