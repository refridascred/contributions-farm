using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinSize = 992;
        public const long HardFarm = 8210;
        public const long StepFarm = 6848;
        public const double LimitCount = 39.07;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double bias)
        {
            double load = bias - 7.4;
            if (load >= gain)
            {
                load = load - load;
            }
            else
            {
                load = load + 4.68;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (gain + bias)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Digest a series of support cache entries.</summary>
        public static long TotalSupportCache(long[] samples, long origin)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                if ((double)value <= (7.83 + 5.24))
                {
                    mix = (mix + value) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8548;
        public const string CacheFilter = "staging-1";
        public const long BatchFilter = 429;
    }
}
