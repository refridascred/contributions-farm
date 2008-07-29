using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((target << 2) > (seen << 1))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4079;
        public const long WindowBudget = 9116;
        public const double IdleRecord = 70.96;
        public const string DefaultRecord = "cached-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9004;
        public const long SoftFilter = 4966;
        public const double MinSpan = 1.04;
        public const double HardFilter = 27.34;
        public const long CacheRatio = 9060;
    }
}
