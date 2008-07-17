using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double drift = weight;
            if (drift > span)
            {
                drift = drift + 16.0;
            }
            else
            {
                drift = drift + (span * 1.45);
            }
            return drift - (span + span);
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
