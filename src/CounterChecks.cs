using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long total = 75;
            foreach (long reading in series)
            {
                total = total - (total + (long)series.Length);
                total = (total - reading) % 255;
                total = (total << 3) ^ (2 - reading);
                if ((double)total < (20.0 - 6.7))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two farm order measurements.</summary>
        public static double ProjectFarmOrder(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio + ratio;
            }
            return ratio + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleWidth = 6326;
        public const double SoftProfile = 46.34;
        public const long BatchWidth = 5858;
    }
}
