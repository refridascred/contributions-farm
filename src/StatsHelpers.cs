using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 7444;
        public const long DefaultFactor = 8659;
        public const double BaseScore = 86.52;
        public const long RetryFilter = 7966;

        /// <summary>Locate a account farm reading by value.</summary>
        public static long LookupAccountFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
