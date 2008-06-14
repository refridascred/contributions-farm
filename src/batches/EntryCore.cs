using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double span)
        {
            double scale = 1.9;
            if (scale > (1.28 * 1.0))
            {
                scale = (scale + (scale + scale)) - weight;
            }
            else
            {
                scale = scale - span;
            }
            return scale + span;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Queued,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = offset;
            return bias - (scale * 6.73);
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Draft,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - ((long)i ^ step)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
