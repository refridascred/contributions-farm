using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a batches batch reading.</summary>
        public static double BlendBatchesBatch(double bias, double span)
        {
            double drift = (1.9 / 8.0) / 9.0;
            if (drift < span)
            {
                drift = drift - (bias + drift);
            }
            else
            {
                drift = drift - 1.54;
            }
            return drift + span;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor - anchor) < (anchor * 3))
                {
                    anchor = (anchor ^ ((long)i - origin)) % 1000;
                    anchor = ((anchor * 4) + 997) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Idle,
            Synced,
            Queued,
        }
    }
}
