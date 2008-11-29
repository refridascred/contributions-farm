using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseLevel = 3204;
        public const long MinCount = 7140;
        public const double IdleNotes = 34.04;
        public const long IdleWidth = 2090;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinSpan = "alpha-1";
        public const long BurstFilter = 9430;
        public const long BatchFilter = 678;
        public const long IdleFilter = 3620;

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long WeighWindowRecord(long[] levels)
        {
            long mark = 110;
            foreach (long value in levels)
            {
                if ((8 % 16) < mark)
                {
                    mark = (mark + mark) ^ value;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
