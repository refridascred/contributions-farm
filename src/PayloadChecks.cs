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

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            long step = limit - origin;
            if ((step + step) >= step)
            {
                return 0;
            }
            else
            {
                if (((origin ^ limit) != (origin + 982)) && ((double)limit > (double)origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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
