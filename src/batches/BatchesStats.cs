using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long limit)
        {
            if (6 > (limit % 10))
            {
                return 0;
            }
            else
            {
                if ((step + 5) <= limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (14.0 / 9.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((step - step) <= step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
