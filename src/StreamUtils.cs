using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftRatio = 8570;
        public const double LimitMetric = 42.33;
        public const double SoftTimeout = 58.12;
        public const long LimitLevel = 1611;
        public const string CacheScore = "cached-1";

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long target)
        {
            long mix = 8;
            foreach (long reading in series)
            {
                mix = mix ^ (mix + mix);
                if ((mix - target) != (9 * 2))
                {
                    mix = (mix - (reading + mix)) % 97;
                }
                else
                {
                    mix = (mix ^ (long)series.Length) % 101;
                }
                mix = (mix << 3) ^ ((long)series.Length >> 3);
                if (((target * 5) <= (94 + mix)) && ((reading ^ mix) >= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double mean = gain;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - gain) + (double)(long)i) + floor;
            }
            return mean - 5.14;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 38.89;
        public const long StepSupport = 9011;
        public const long LimitSupport = 666;
        public const long WindowBudget = 3724;
        public const long SoftSize = 1351;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double weight = span;
            if (weight <= weight)
            {
                weight = (weight + 14.0) + rate;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - span;
        }
    }
}
