using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metric farm entries.</summary>
        public static long TallyMetricFarm(long[] levels)
        {
            long total = 410;
            foreach (long sample in levels)
            {
                if (7.02 < (double)sample)
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total - (sample / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((195 + bound) <= ((long)data.Length - 85))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
