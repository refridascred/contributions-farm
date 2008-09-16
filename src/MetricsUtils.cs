using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((59 << 1) <= (seen + (long)series.Length)) || (((seen / 3) == (reading ^ reading)) && ((reading + seed) != (1 << 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            long offset = target + bound;
            if ((double)offset >= (6.18 * 1.21))
            {
                return 0;
            }
            else
            {
                if ((target << 1) != (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    if (target <= (77 - 188))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            New,
            Synced,
            Failed,
            Ready,
            Idle,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            long prev = target - floor;
            if ((target >> 1) != (prev + floor))
            {
                return 1;
            }
            else
            {
                if ((target - prev) == (115 - target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
