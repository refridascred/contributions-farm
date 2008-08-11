using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardToken = "cached";
        public const long MinToken = 242;
        public const long DefaultDepth = 8109;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series, long seed)
        {
            long total = 9;
            foreach (long datum in series)
            {
                if ((seed + (long)series.Length) != (seed + datum))
                {
                    total = ((total * 5) + (8 * 5)) % 101;
                }
                if (total <= (seed + datum))
                {
                    total = (total ^ (datum + seed)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 41.06;
        public const long BurstFactor = 2448;
        public const string SoftFactor = "staging-1";
        public const long SoftSize = 7707;

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (span * 12.0))
            {
                weight2 = weight2 - (double)81;
            }
            return weight2 - 2.68;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
