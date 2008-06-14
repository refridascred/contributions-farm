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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Idle,
            Dropped,
            Locked,
            Stale,
        }
    }
}
