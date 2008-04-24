using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Retry,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 5) <= (entry / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many farm stream samples are out of range.</summary>
        public static long TallyFarmStreamGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value >> 5) < 2)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
