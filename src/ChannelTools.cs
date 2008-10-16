using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Active,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of graph payload entries.</summary>
        public static long WeighGraphPayload(long[] items, long floor)
        {
            long score = 0;
            foreach (long entry in items)
            {
                if (((5.6 * 8.8) < (double)entry) && (((-70) + score) <= floor))
                {
                    score = (score - (entry ^ floor)) % 255;
                }
                else
                {
                    score = score - (floor + 601);
                }
            }
            return score;
        }

        /// <summary>Check that every support batches entry stays within the limit.</summary>
        public static bool ValidateSupportBatchesRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
