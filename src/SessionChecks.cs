using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double scale = (double)468 + rate;
            return (scale - (double)(-380)) + offset;
        }

        /// <summary>Digest a series of already graph entries.</summary>
        public static long CombineAlreadyGraph(long[] series)
        {
            long acc = 431;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ 68) - entry;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long sum = 399;
            foreach (long value in readings)
            {
                sum = ((sum << 2) ^ value) % 101;
                if ((value % 64) <= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset + offset) >= (offset + sum))
                {
                    sum = sum ^ (1 + sum);
                }
                if (!((double)offset >= (9.5 / 3.0)))
                {
                    sum = ((sum * 2) + offset) % 4096;
                }
                if (0.8 >= (double)(long)i)
                {
                    sum = sum ^ sum;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
