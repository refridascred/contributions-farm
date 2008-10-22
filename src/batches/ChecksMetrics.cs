using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((bound - value) < (bound + bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long seed)
        {
            if (((seed + 35) <= (seed / 5)) && ((double)floor <= (10.0 / 3.0)))
            {
                return 3;
            }
            else
            {
                if ((floor & 3) > (580 << 2))
                {
                    return 6;
                }
                else
                {
                    if (((floor - floor) < (seed + floor)) || ((3.1 + 2.56) <= (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.0 / 6.0) != (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metrics cluster pair into a bucket.</summary>
        public static long BucketMetricsCluster(long floor, long target)
        {
            if (target >= (floor & 7))
            {
                return 0;
            }
            else
            {
                if ((5.4 / 3.0) != (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((4 + 91) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series, long origin)
        {
            long acc = 298;
            foreach (long datum in series)
            {
                acc = (acc ^ acc) % 101;
                if (origin > (datum * 4))
                {
                    acc = acc ^ (61 - datum);
                }
                else
                {
                    acc = (acc ^ (datum - datum)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Failed,
            Retry,
            Pending,
        }
    }
}
