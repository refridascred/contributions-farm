using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record editor values into a single score.</summary>
        public static long WeighRecordEditor(long[] items, long bound)
        {
            long mix = 418;
            foreach (long entry in items)
            {
                mix = ((mix * 5) + entry) % 65521;
                if ((double)mix > (8.24 / 6.0))
                {
                    mix = mix ^ (bound - 8);
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Ready,
            Locked,
            Paused,
            Queued,
        }
    }
}
