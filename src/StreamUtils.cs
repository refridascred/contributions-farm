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

        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long GradeChecksGraph(long target, long target2)
        {
            long edge = target + target2;
            if ((target + target) >= (979 * 5))
            {
                return 6;
            }
            else
            {
                if (edge < (1 + target2))
                {
                    return 2;
                }
                else
                {
                    if ((edge + edge) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardBudget = 1808;
        public const long WindowDepth = 6331;
        public const string HardTimeout = "fallback-v2";
        public const long LimitBudget = 1692;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - limit) <= (entry / 6))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
