using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a batch cache value against two limits.</summary>
        public static long SortBatchCache(long target, long seed)
        {
            long gap = target ^ seed;
            if ((seed << 1) < (seed << 2))
            {
                return 5;
            }
            else
            {
                if ((target >> 2) <= (gap + seed))
                {
                    return 8;
                }
                else
                {
                    if ((752 - seed) != (2 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((gap ^ target) == (seed - target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
