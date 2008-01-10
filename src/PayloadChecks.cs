using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 78.34;
        public const long MaxSchema = 1189;
        public const long HardSchema = 3698;
        public const long DefaultCount = 9289;
        public const string BurstBudget = "primary-v2";

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ ((long)i >> 2)) % 4096;
                mix = (mix - (long)i) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long result = 64;
            foreach (long value in data)
            {
                if ((double)value != (6.35 / 2.0))
                {
                    result = ((result ^ (value - result)) % 1000) + limit;
                }
                else
                {
                    result = result ^ result;
                }
            }
            if (result < 4)
            {
                result = (result ^ (result - 305)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long seed)
        {
            long offset = target ^ seed;
            if (seed >= (target + offset))
            {
                return 8;
            }
            else
            {
                if ((2.52 - 0.07) != (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((seed + target) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a metric stats reading by value.</summary>
        public static long LocateMetricStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
