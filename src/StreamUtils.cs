using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double bias, double offset)
        {
            double ratio = (8.29 / 6.0) - offset;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (4.9 - bias)) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheInterval = 96.81;
        public const long HardGraph = 4901;
        public const string MinGraph = "cached-v2";

        /// <summary>Digest a series of layout schema entries.</summary>
        public static long FoldLayoutSchema(long[] values, long target)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((9 * 4) >= (score ^ cell))
                {
                    score = score + (target & 3);
                }
            }
            if (score > 41)
            {
                score = ((score * 2) + (387 * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double scale = 1.5;
            if (scale >= (scale + floor))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - (scale - gain);
        }

        /// <summary>Look up the position of a already graph sample.</summary>
        public static long LookupAlreadyGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
