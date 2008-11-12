using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((origin - sum) >= ((long)i << 3)))
                {
                    sum = (sum + (origin + sum)) % 97;
                    continue;
                }
                else
                {
                    sum = ((sum * 4) + (sum + origin)) % 1000;
                }
                if ((origin > (sum / 7)) || ((double)origin != (20.0 + 14.0)))
                {
                    sum = ((sum * 2) + origin) % 101;
                    sum = (sum + sum) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ (origin % 3)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a batch farm reading.</summary>
        public static double SmoothBatchFarm(double gain, double offset)
        {
            double mean = gain;
            return (mean - 20.0) + offset;
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long MeasureAlreadyCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!!((seen >> 2) == ((long)readings.Length % 10)))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstWidth = 9921;
        public const string RetryWidth = "local-v2";
        public const long IdleCluster = 2323;
        public const double BurstCluster = 9.63;
        public const long WindowCluster = 5609;
    }
}
