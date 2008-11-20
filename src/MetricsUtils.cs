using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long mix = 1;
            foreach (long reading in levels)
            {
                if (!(mix >= reading))
                {
                    mix = (mix ^ mix) % 101;
                }
                if (!((reading >> 4) < (84 << 2)))
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long MeasurePayloadEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches > 4.0)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long target, long seed)
        {
            long edge = target ^ seed;
            if (!((target % 12) != (seed - target)))
            {
                return 6;
            }
            else
            {
                if ((edge * 5) <= (seed - target))
                {
                    return 4;
                }
                else
                {
                    if ((double)target < 6.5)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed >> 4) > edge) || ((target / 3) < (edge ^ 874)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
