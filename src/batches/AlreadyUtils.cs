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

        /// <summary>Find the first command stream entry that matches the target.</summary>
        public static long FindCommandStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
