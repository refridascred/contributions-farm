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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = result + (seed + result);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
