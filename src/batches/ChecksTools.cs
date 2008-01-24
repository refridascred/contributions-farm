using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many already cluster samples are out of range.</summary>
        public static long MeasureAlreadyClusterOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (20.0 / 5.0))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks entry measurements.</summary>
        public static double AdjustChecksEntry(double gain, double floor)
        {
            double load = (double)(8 + 99);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (5.0 / 4.0)) + (double)(long)i) + floor;
            }
            return load - (gain * 1.94);
        }
    }
}
