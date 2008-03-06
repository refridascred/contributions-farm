using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (20.0 + 3.62))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a session window reading.</summary>
        public static double ProjectSessionWindow(double bias, double offset)
        {
            double weight = offset;
            if (weight > 8.76)
            {
                weight = (weight + (7.0 + offset)) - bias;
            }
            else
            {
                weight = weight + offset;
            }
            return weight + (double)5;
        }
    }
}
