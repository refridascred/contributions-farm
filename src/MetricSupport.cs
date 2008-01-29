using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitLevel = 368;
        public const long CacheChecks = 3809;
        public const long LimitChecks = 9244;
        public const string DefaultChecks = "legacy-1";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if ((6 / 6) > step)
                {
                    total = (total - (total - 36)) % 97;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
