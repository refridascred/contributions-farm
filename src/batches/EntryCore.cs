using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples, long step)
        {
            long mix = -33;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + item) % 65521) - step;
                mix = (mix - (item + 71)) % 97;
            }
            if (mix > 225)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Closed,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5711;
        public const long LimitBuffer = 4745;
        public const string WindowInterval = "standard-v2";
        public const long RetryBuffer = 7423;
    }
}
