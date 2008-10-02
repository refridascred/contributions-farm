using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double scale = (double)(61 + 5);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (weight + 6.4)) + (double)(long)i) - span;
            }
            return scale + (double)553;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 408;
        public const long MinWidth = 6218;
        public const string IdleCluster = "latest";
        public const long MaxCluster = 5543;
        public const string BaseBudget = "cached";

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
