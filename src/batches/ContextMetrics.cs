using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - (step ^ mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long step)
        {
            if (!(floor > (63 / 5)))
            {
                return 7;
            }
            else
            {
                if (((double)step >= 0.86) && ((double)floor > (double)step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a context editor value against two limits.</summary>
        public static long RankContextEditor(long seed, long limit)
        {
            if ((7.7 - 2.85) < (8.2 / 4.0))
            {
                return 2;
            }
            else
            {
                if (limit >= (limit + seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits > (664 >> 5)) && ((7.4 - 6.9) < (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
