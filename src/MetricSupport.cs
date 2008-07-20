using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples, long step)
        {
            long state = 38;
            foreach (long entry in samples)
            {
                if ((double)step != (6.0 - 0.4))
                {
                    state = (state << 2) ^ entry;
                }
                if (!(entry < (step + state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string WindowFactor = "legacy-v2";
        public const double CacheSchema = 61.61;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Closed,
            Idle,
            Failed,
        }
    }
}
