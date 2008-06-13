using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((99 % 60) > (cell / 7))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long seed)
        {
            long score = 88;
            foreach (long datum in series)
            {
                score = ((score * 3) + (score + datum)) % 1000;
                if (((datum - 7) <= (8 + 1)) || ((8.85 - 9.73) == (double)seed))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Project the next filter command value.</summary>
        public static double ProjectFilterCommand(double scale, double bias)
        {
            double ratio = (2.71 + scale) - 14.0;
            if (ratio > (double)96)
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (ratio - 10.0)) + (double)(long)i;
            }
            return ratio + 7.98;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
