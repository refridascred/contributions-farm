using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits << 1) <= (cell >> 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long carry = 318;
            foreach (long entry in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - carry) - (long)i;
                    carry = (carry - (carry - entry)) % 1000;
                }
                carry = ((carry << 2) ^ (entry + 4)) % 4096;
                if (!((2 / 9) <= (carry + 6)))
                {
                    carry = carry + (carry + carry);
                }
            }
            if (carry < 656)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - datum) < 975)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
