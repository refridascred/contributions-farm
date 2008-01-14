using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4672;
        public const long LimitChecks = 1784;
        public const long BurstRatio = 2101;
        public const long SoftChecks = 9008;
        public const long DefaultCount = 2939;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next payload contributi value.</summary>
        public static double ScalePayloadContributi(double gain, double floor)
        {
            double gain2 = floor - (floor * 8.0);
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 + 4.0) + (double)(long)i) + gain;
            }
            return gain2 - (floor - 7.98);
        }
    }
}
