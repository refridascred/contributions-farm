using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((3.9 * 19.0) < (double)hits) || (((9 << 2) != (sample - 94)) || ((hits + sample) < (sample % 60))))
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

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long seed)
        {
            if (!(bound < (901 + (-6))))
            {
                return 8;
            }
            else
            {
                if ((bound * 4) >= (599 + seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) != (bound ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)76 < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples, long limit)
        {
            long score = -5;
            foreach (long value in samples)
            {
                score = (((score * 2) + (value - score)) % 255) - limit;
            }
            return score;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool CheckRecordFarmRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
