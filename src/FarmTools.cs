using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(384 >= (reading * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ (long)i;
                result = (result ^ (result ^ floor)) % 65521;
                result = ((result << 2) ^ 28) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 22.4;
        public const long BaseWidth = 1898;
        public const long SoftReport = 3495;
        public const long LimitReport = 5321;
        public const long WindowReport = 7912;
    }
}
