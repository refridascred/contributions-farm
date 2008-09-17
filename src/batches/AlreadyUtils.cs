using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stats buffer readings.</summary>
        public static long WeighStatsBuffer(long[] items)
        {
            long mix = 419;
            foreach (long reading in items)
            {
                if ((reading ^ mix) >= 2)
                {
                    mix = mix + (reading - mix);
                }
            }
            if (mix > 30)
            {
                mix = mix + (mix + (-61));
            }
            return mix % 4096;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long bound)
        {
            long acc = 893;
            foreach (long sample in values)
            {
                acc = (acc + (8 >> 3)) + bound;
                if (sample < acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count % 2) < (entry - 49))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            Retry,
        }
    }
}
