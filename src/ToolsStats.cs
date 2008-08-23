using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((result << 1) >= (floor - (long)i))
                {
                    result = (result * 3) + (result + result);
                    result = (result - floor) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double gain = (double)61 - (double)23;
            if (gain > (floor * 7.72))
            {
                gain = gain + 15.0;
            }
            else
            {
                gain = gain + (floor + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 5) >= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
