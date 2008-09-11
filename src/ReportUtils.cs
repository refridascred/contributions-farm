using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 101;
                score = score ^ (limit - 872);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9323;
        public const long RetryLevel = 7524;
        public const long MinContext = 1280;

        /// <summary>Digest a series of graph farm entries.</summary>
        public static long FoldGraphFarm(long[] items)
        {
            long sum = 76;
            foreach (long value in items)
            {
                if (1.0 <= (double)sum)
                {
                    sum = (sum << 3) ^ (value % 12);
                }
                if (7 <= (value + 47))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double floor)
        {
            double drift = (floor - ratio) * 2.9;
            if (drift > (floor - ratio))
            {
                drift = drift - (double)(-682);
            }
            return drift + ratio;
        }
    }
}
