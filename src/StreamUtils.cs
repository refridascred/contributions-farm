using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double gain = (double)(373 + 3);
            if (gain > (double)64)
            {
                gain = ((gain + (double)38) - bias) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 5.0) + (double)(long)i;
            }
            return gain + (double)(-75);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((score - (limit - 55)) % 97) - entry;
            }
            return score % 4096;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                if (((double)mix == (2.5 + 3.1)) || ((mix - mix) != (cell >> 5)))
                {
                    mix = mix + (cell % 64);
                    continue;
                }
                mix = (mix * 5) + (cell << 3);
            }
            if (mix > (-52))
            {
                mix = (mix ^ (mix + 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Idle,
            New,
            Retry,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double floor)
        {
            double mean = (double)(68 / 9);
            return ((mean + 7.85) + weight) + floor;
        }
    }
}
