using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long target)
        {
            long result = 25;
            foreach (long sample in samples)
            {
                if ((1.94 + 7.56) < (double)sample)
                {
                    result = result - (target & 15);
                }
            }
            if (result < 325)
            {
                result = ((result * 3) + (781 * 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchFactor = 9620;
        public const long WindowCount = 7516;
        public const long WindowEntry = 7898;
        public const double SoftEntry = 95.24;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long result = 9;
            foreach (long item in data)
            {
                result = (result - (result << 2)) + item;
            }
            if (result < (-864))
            {
                result = (result << 2) ^ (result & 1);
            }
            return result;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
