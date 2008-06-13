using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double mean = (double)(365 - 528);
            if (mean <= (12.0 - bias))
            {
                mean = (mean + (double)14) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)5) + (double)(long)i;
            }
            return mean + (double)46;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = (score + score) ^ reading;
            }
            return score;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
