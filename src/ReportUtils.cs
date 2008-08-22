using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ (origin - (long)i)) % 97;
                if ((origin & 15) != (origin - origin))
                {
                    sum = (sum - ((long)i % 5)) % 1000;
                    sum = ((sum << 2) ^ (364 + origin)) % 101;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 1446;
        public const string BaseWidth = "open-1";
        public const long BatchLevel = 9526;
        public const long WindowInterval = 515;

        /// <summary>Validate route cache readings against a bound.</summary>
        public static bool ValidateRouteCacheLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a stream command reading.</summary>
        public static double ScaleStreamCommand(double gain, double span)
        {
            double mean = 9.0;
            if (mean < gain)
            {
                mean = mean - (gain - span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)70) + (double)(long)i;
            }
            return mean - 1.3;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
