using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - limit;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
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
