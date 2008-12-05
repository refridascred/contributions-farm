using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of session command readings.</summary>
        public static long PairSessionCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double bias = (17.0 * 4.33) - (scale - span);
            if (bias >= (double)889)
            {
                bias = bias + (span / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)991) - (double)(long)i;
            }
            return bias + 4.2;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 7018;
        public const string StepEntry = "primary";
        public const double DefaultEntry = 28.03;
        public const long BatchEntry = 3671;
        public const double WindowSize = 92.52;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
