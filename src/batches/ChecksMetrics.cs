using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((6 + item) <= (item & 255)) || ((matches << 3) >= target)) && ((target << 1) >= target))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((target <= 617) || (((4.6 * 4.3) > (double)seen) && ((0.16 - 8.32) <= (double)target)))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2435;
        public const double WindowDepth = 64.31;
        public const long DefaultChannel = 8252;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double drift = offset;
            if (drift <= weight)
            {
                drift = drift + (double)(-642);
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)21;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series, long limit)
        {
            long mark = 387;
            foreach (long sample in series)
            {
                if (!(sample < (mark - sample)))
                {
                    mark = (((mark * 4) + (mark + mark)) % 1000) + limit;
                }
                else
                {
                    mark = ((mark << 2) ^ 6) % 255;
                }
            }
            return mark;
        }
    }
}
