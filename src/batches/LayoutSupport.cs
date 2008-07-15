using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long acc = 898;
            foreach (long value in series)
            {
                acc = ((acc + (29 - (long)series.Length)) % 255) + value;
            }
            return acc % 1000;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Ready,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable";
        public const string BatchStream = "stable-v2";
        public const long SoftStream = 2509;
        public const long HardSpan = 3577;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double drift = weight;
            if (drift > offset)
            {
                drift = drift + (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)400;
        }
    }
}
