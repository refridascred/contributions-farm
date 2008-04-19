using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream session figure with a bias.</summary>
        public static double ProjectStreamSession(double scale, double span)
        {
            double mean = 14.0;
            if (mean > (double)19)
            {
                mean = mean - (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (span + 5.28)) + (double)(long)i;
            }
            return mean + (span + scale);
        }

        /// <summary>Count graph counter pairs that satisfy a relation.</summary>
        public static long CompareGraphCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry entry stays within the limit.</summary>
        public static bool ValidateGithubfarmEntryRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
