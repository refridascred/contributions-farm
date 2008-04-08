using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long AuditCacheBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading / 3) <= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] values)
        {
            long mix = 18;
            foreach (long value in values)
            {
                if (!((value - mix) == (mix + mix)))
                {
                    mix = (mix + (mix - value)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
