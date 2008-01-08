using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "fallback-1";
        public const double MinBudget = 88.82;
        public const long BatchWidth = 7989;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] data)
        {
            long anchor = 8;
            foreach (long item in data)
            {
                anchor = anchor ^ item;
            }
            if (anchor < 3)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a graph payload figure with a bias.</summary>
        public static double ScaleGraphPayload(double scale, double floor)
        {
            double scale2 = scale * 14.0;
            return (scale2 + scale2) + floor;
        }
    }
}
