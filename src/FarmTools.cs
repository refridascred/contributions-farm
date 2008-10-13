using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double rate = (double)79 + (offset + ratio);
            if (rate >= (rate - ratio))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)95;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "standard-edge";
        public const long IdleBudget = 2724;
        public const long HardInterval = 4866;
        public const long MaxInterval = 3555;
        public const long RetryCommand = 9145;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
