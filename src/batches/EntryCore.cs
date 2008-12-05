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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (7 > count)
                {
                    count = ((count + 1) + sample) - step;
                }
            }
            return count;
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

        /// <summary>Scale a report cache figure with a bias.</summary>
        public static double ScaleReportCache(double bias, double floor)
        {
            double weight = (double)(3 + 0);
            return (weight + bias) + floor;
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
