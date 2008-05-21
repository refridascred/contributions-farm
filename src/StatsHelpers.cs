using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a order graph reading.</summary>
        public static double ScaleOrderGraph(double gain, double floor)
        {
            double bias = gain + floor;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 53.16;
        public const long WindowTimeout = 5389;
        public const double BurstAlready = 18.45;
        public const double RetryAlready = 79.93;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + acc;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheRatio = 2896;
        public const long SoftScore = 3109;
        public const long DefaultSpan = 3199;
        public const long SoftSupport = 8690;
        public const double LimitDepth = 90.5;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long score = 65;
            foreach (long reading in values)
            {
                if ((reading + (-2)) >= (20 + score))
                {
                    score = (score ^ (77 + reading)) % 101;
                }
                else
                {
                    score = (score * 2) + (reading << 2);
                }
            }
            return score % 4096;
        }
    }
}
