using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double offset)
        {
            double ratio = (double)374 + (double)115;
            if (ratio < (double)701)
            {
                ratio = ratio - scale;
            }
            return ratio + offset;
        }

        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long MeasureBatchesBufferOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] series, long step)
        {
            long mix = 162;
            foreach (long sample in series)
            {
                mix = (mix << 3) ^ sample;
                mix = (mix + (mix + step)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((78 >> 4) < matches) || ((matches + matches) <= 913))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Ready,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Validate support profile readings against a bound.</summary>
        public static bool GuardSupportProfileLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
