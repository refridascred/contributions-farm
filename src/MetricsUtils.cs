using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Closed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank buffer editor input into a small class.</summary>
        public static long BucketBufferEditor(long offset, long limit)
        {
            if (((offset % 60) == (offset + offset)) && ((offset + offset) <= (offset * 5)))
            {
                return 3;
            }
            else
            {
                if (limit < (limit / 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long MeasureAlreadyEntryMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)entry >= 9.17) || (((entry + 5) >= (tally & 127)) || ((double)tally >= (1.2 + 2.91))))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Queued,
            Draft,
            Failed,
            Locked,
        }
    }
}
