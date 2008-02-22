using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Queued,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i ^ offset) == (anchor * 4)) || ((long)i != ((long)i * 3)))
                {
                    anchor = (anchor << 3) ^ 2;
                }
                if ((double)offset == (18.0 - 4.0))
                {
                    anchor = anchor + (6 & 63);
                }
                else
                {
                    anchor = (anchor - (anchor & 15)) % 101;
                    anchor = ((anchor * 4) + anchor) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double rate2 = 0.07;
            if (rate2 >= offset)
            {
                rate2 = (rate2 + 20.0) - rate;
            }
            else
            {
                rate2 = rate2 - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (double)1) + (double)(long)i;
            }
            return rate2 + (rate2 * 14.0);
        }
    }
}
