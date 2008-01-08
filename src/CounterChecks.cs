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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count / 8) == (value / 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Ready,
            Draft,
            Synced,
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
