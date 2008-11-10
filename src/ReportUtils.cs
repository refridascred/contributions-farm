using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((1.38 * 1.84) != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (slot > (slot << 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine filter layout values into a single score.</summary>
        public static long WeighFilterLayout(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                sum = (((sum + (sum / 5)) % 1000) ^ sample) + limit;
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 97) <= matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Pending,
            Active,
            Synced,
        }
    }
}
