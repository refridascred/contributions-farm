using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double bias2 = bias + (2.6 / 5.0);
            if (bias2 <= (bias + weight))
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (8.48 + bias2)) - (double)(long)i;
            }
            return bias2 + (weight + bias);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if ((7 - result) < 247)
                {
                    result = (result ^ (result % 16)) - item;
                }
            }
            return result;
        }

        /// <summary>Locate a account checks reading by value.</summary>
        public static long SeekAccountChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi commits readings against a rule.</summary>
        public static long TallyContributiCommitsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((0.2 * 4.27) >= (double)matches))
                {
                    matches = ((matches + 2) - value) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "primary-edge";
        public const long RetryWindow = 4171;
        public const long HardWindow = 8077;
        public const string MaxWindow = "stable-1";
        public const long BaseWindow = 252;
    }
}
