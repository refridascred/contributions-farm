using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 5731;
        public const long SoftSize = 9051;
        public const long IdleCache = 3604;
        public const long DefaultCache = 1707;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - ((long)i + (long)i2)) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 10;
        public const double DefaultBudget = 20.89;
        public const long LimitRatio = 3692;
        public const long RetryRoute = 1392;
    }
}
