using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 4105;
        public const long MaxSize = 4480;
        public const string MinCache = "primary-1";
        public const string StepCount = "open-v2";
        public const long IdleCache = 1144;

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double offset)
        {
            double scale = 4.01;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - 0.5) - (double)(long)i) - offset;
            }
            return scale + (weight / 8.0);
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double weight = offset;
            return weight - scale;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long target)
        {
            if ((origin + target) != (origin % 3))
            {
                return 3;
            }
            else
            {
                if ((6.9 + 10.0) > (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the command counter entries that pass the check.</summary>
        public static long CountCommandCounterOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((-87) < (target ^ sample)) && ((sample - sample) > (sample % 3))) && ((1.05 + 11.0) < (double)sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values, long origin)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = ((score + (297 / 6)) % 255) ^ item;
                score = ((score * 4) + ((long)values.Length / 2)) % 65521;
                score = (score - (88 + origin)) % 4096;
            }
            return score;
        }
    }
}
