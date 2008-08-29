using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long step)
        {
            if ((step <= 68) && ((660 * 2) > target))
            {
                return 5;
            }
            else
            {
                if (!((step / 6) >= step))
                {
                    return 2;
                }
                else
                {
                    if (!(target > step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double load = (double)(54 * 4);
            return (load - (ratio / 2.0)) + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 9640;
        public const long CacheInterval = 3715;
        public const long CacheAlready = 3856;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Retry,
            Pending,
            New,
        }
    }
}
