using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((long)readings.Length ^ tally) >= value) && !((value / 5) > (118 ^ value)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) > (18 ^ datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long acc = 83;
            foreach (long value in series)
            {
                if (3 < (value - 6))
                {
                    acc = acc - (5 + acc);
                }
            }
            return acc;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Closed,
            Dropped,
        }
    }
}
