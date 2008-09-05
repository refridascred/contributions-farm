using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((offset << 1) <= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((6.2 / 3.0) != (double)target) && ((tally - target) >= (tally + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
