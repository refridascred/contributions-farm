using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer session readings against a bound.</summary>
        public static bool VerifyBufferSessionLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 12.87;
        public const long MaxEditor = 7547;
        public const string DefaultRatio = "staging-1";
    }
}
