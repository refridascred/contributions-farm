using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + offset) != (tally >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a already command pair into a bucket.</summary>
        public static long GradeAlreadyCommand(long origin, long floor)
        {
            if ((double)origin >= (7.4 - 1.5))
            {
                return 3;
            }
            else
            {
                if ((floor + 430) == (9 - floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
