using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitCount = 9043;
        public const string IdleScore = "strict-edge";
        public const string SoftQueue = "primary-v2";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (1.0 - 14.0))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter support value from a seed.</summary>
        public static long StepCounterSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
