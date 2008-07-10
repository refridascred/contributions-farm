using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (target ^ acc);
                if ((double)acc <= 17.0)
                {
                    acc = (acc << 2) ^ (acc ^ acc);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7362;
        public const double IdleGraph = 18.93;
        public const long SoftBudget = 1329;
        public const long DefaultFactor = 3724;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Synced,
        }
    }
}
