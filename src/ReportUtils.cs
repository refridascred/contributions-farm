using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long LocateOrderChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-v2";
        public const long BurstScore = 8179;
        public const long DefaultSize = 611;
        public const double WindowChecks = 26.2;
        public const double SoftInterval = 47.05;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Synced,
            Paused,
            Closed,
            Locked,
        }
    }
}
