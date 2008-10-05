using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double load = 6.9 + (gain + gain);
            return load - (gain + bias);
        }

        /// <summary>Check that every account session entry stays within the limit.</summary>
        public static bool CheckAccountSessionBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Dropped,
            Retry,
            New,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (!((origin2 & 31) <= delta))
            {
                return 2;
            }
            else
            {
                if ((origin2 * 4) == (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if ((delta + origin2) == (origin + delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin & 3) <= (delta + 76))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
