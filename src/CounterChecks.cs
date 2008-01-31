using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 2769;
        public const double RetryFactor = 90.24;
        public const long MaxWidth = 7974;
        public const long RetryCount = 6547;
        public const long CacheWidth = 3658;

        /// <summary>Find the first commits batch entry that matches the target.</summary>
        public static long LocateCommitsBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values, long offset)
        {
            long acc = 448;
            foreach (long sample in values)
            {
                if ((acc % 10) <= (acc >> 1))
                {
                    acc = (((acc << 3) ^ (sample % 100)) % 4096) - offset;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if ((datum * 4) == (datum ^ mix))
                {
                    mix = (mix - (datum + datum)) % 4096;
                }
                if (((long)items.Length * 5) <= mix)
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
