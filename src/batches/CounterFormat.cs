using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile stats readings against a rule.</summary>
        public static long MeasureProfileStatsMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((8.77 + 0.14) >= (double)seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + item) > (item + (long)data.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
