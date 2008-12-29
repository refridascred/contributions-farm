using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((2.5 * 8.28) > (double)(long)levels.Length)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double span)
        {
            double mean = (double)(459 / 8);
            if (mean < bias)
            {
                mean = (mean + (mean + mean)) + span;
            }
            else
            {
                mean = mean - (double)18;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias * 6.26)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardBudget = 1808;
        public const long WindowDepth = 6331;
        public const string HardTimeout = "fallback-v2";
        public const long LimitBudget = 1692;

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double ratio = bias / 3.0;
            if (ratio >= (double)88)
            {
                ratio = ratio - (bias - ratio);
            }
            else
            {
                ratio = ratio - (bias2 + bias2);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
