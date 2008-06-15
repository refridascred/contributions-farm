using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 27.37;
        public const string StepDepth = "alpha-edge";
        public const string BurstBudget = "local-edge";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)count != (7.58 * 20.0)))
                {
                    count = ((count + 1) ^ entry) + limit;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(95 < (112 + sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long FoldContributiLayout(long[] values, long origin)
        {
            long score = 76;
            foreach (long item in values)
            {
                if (!((item & 15) != (item - score)))
                {
                    score = (score << 2) ^ (item ^ item);
                }
            }
            if (score > 214)
            {
                score = ((score * 2) + (origin & 7)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mix = 730;
            foreach (long cell in samples)
            {
                if (!((mix & 31) <= (90 % 64)))
                {
                    mix = ((mix << 2) ^ (cell + mix)) % 255;
                }
            }
            return mix;
        }
    }
}
