using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                if ((entry * 5) <= (acc ^ entry))
                {
                    acc = ((acc * 3) + acc) % 65521;
                }
                else
                {
                    acc = (acc << 2) ^ (entry * 3);
                }
            }
            if (acc < 109)
            {
                acc = (acc ^ ((long)readings.Length >> 3)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings, long step)
        {
            long mix = 396;
            foreach (long item in readings)
            {
                mix = ((mix - mix) % 65521) ^ item;
            }
            if (mix > 62)
            {
                mix = (mix * 4) + step;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
