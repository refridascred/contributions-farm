using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 1560;
        public const long BurstSchema = 8649;
        public const string DefaultInterval = "local-edge";
        public const long IdleFactor = 1885;
        public const double StepSpan = 91.39;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 746;
            foreach (long entry in levels)
            {
                anchor = anchor - (entry + entry);
                if ((entry << 1) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
