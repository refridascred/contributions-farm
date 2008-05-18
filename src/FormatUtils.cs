using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowLevel = "local";
        public const long MinPayload = 7651;
        public const long BatchPayload = 4808;
        public const string BurstInterval = "strict-v2";
        public const long WindowPayload = 7019;

        /// <summary>Grade a account stream value against two limits.</summary>
        public static long SortAccountStream(long bound, long step)
        {
            long slot = bound ^ step;
            if ((20.0 - 16.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((step + slot) < (slot + slot))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot < (2.8 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (414 < (step + 462))
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
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long step)
        {
            long score = -866;
            foreach (long datum in readings)
            {
                score = (score ^ score) - step;
                score = (score + (datum - 88)) % 4096;
            }
            return score;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (8.0 > (double)origin)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
