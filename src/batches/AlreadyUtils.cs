using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 5) + step) % 4096) ^ (long)i2;
                }
                if ((double)(long)i <= (16.0 - 6.45))
                {
                    acc = (acc + (long)i) % 101;
                }
                else
                {
                    acc = acc - (step & 255);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a profile tools figure with a bias.</summary>
        public static double SmoothProfileTools(double scale, double offset)
        {
            double weight = (4.2 / 6.0) / 9.0;
            return ((weight - (weight / 5.0)) + scale) + offset;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry >> 1) <= ((long)series.Length - count)) || ((entry << 2) >= 272))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
