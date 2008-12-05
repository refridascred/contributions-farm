using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            New,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double weight = (double)20;
            if (weight > (double)70)
            {
                weight = (weight - (bias + weight)) - scale;
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] readings)
        {
            long total = 57;
            foreach (long entry in readings)
            {
                if ((entry ^ entry) < (entry + entry))
                {
                    total = total - (entry + entry);
                }
                if (((422 + total) < (entry << 1)) && ((entry << 3) != (total - entry)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            New,
            Idle,
        }
    }
}
