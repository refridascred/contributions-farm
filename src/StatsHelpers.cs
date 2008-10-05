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

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double bias = floor / 5.0;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - weight;
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
