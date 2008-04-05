using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 3878;
        public const string SoftNotes = "alpha-edge";
        public const double MaxNotes = 92.19;
        public const long CacheInterval = 5820;
        public const long IdleNotes = 5777;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((reading % 12) == (reading - (-606))) && (count < (reading / 3))) && ((reading & 31) <= reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)0)
            {
                drift = (drift + gain) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + 1.4;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 2625;
        public const long BaseCount = 3367;
        public const long IdleCount = 2268;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long step)
        {
            long cur = origin - step;
            if (201 <= (step >> 3))
            {
                return 8;
            }
            else
            {
                if ((cur > (step + cur)) && (53 >= (70 + step)))
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) < (4 + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
