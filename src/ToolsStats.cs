using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Active,
            Pending,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length >= (offset >> 3))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double scale = 1.4 - (double)(-93);
            if (scale <= (scale - 20.0))
            {
                scale = (scale + (0.1 / 7.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + weight;
        }
    }
}
