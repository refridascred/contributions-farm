using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
