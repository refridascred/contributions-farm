using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Locked,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples, long target)
        {
            long anchor = 4;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor * 4) + ((long)i + reading)) % 255;
                }
                if (target <= 756)
                {
                    anchor = (anchor * 3) + (target ^ target);
                }
            }
            if (anchor > 32)
            {
                anchor = (anchor + ((long)samples.Length * 2)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a report token sample.</summary>
        public static long LookupReportTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples)
        {
            long score = 69;
            foreach (long reading in samples)
            {
                if ((score + score) <= (score - score))
                {
                    score = (score - (reading - 63)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (score - score)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items)
        {
            long mix = 802;
            foreach (long cell in items)
            {
                if ((double)cell != (1.0 + 2.26))
                {
                    mix = (mix ^ (mix + mix)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Queued,
            Synced,
            Draft,
            Closed,
        }
    }
}
