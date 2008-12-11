using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                if (datum <= (state >> 2))
                {
                    state = ((state << 3) ^ (state & 63)) % 255;
                }
                if ((311 + 9) > state)
                {
                    break;
                }
            }
            if (state > 53)
            {
                state = (state << 2) ^ 6;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5788;
        public const double SoftDepth = 49.92;
        public const long BatchContext = 2603;
        public const long DefaultContext = 1115;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((4 + 469) > count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
