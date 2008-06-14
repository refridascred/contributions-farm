using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Idle,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if ((carry < entry) && ((carry + entry) >= (carry & 31)))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry < (6.69 * 5.9)) || ((entry + hits) >= (560 - entry))) && (20.0 < (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
