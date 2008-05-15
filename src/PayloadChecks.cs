using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Queued,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 2610;
        public const double BaseBudget = 2.14;
        public const long HardCommand = 9904;
        public const string StepTimeout = "primary-1";

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxFactor = 80.55;
        public const string LimitDepth = "standard-1";
        public const long LimitBuffer = 1025;
        public const string CacheBuffer = "latest-v2";
    }
}
