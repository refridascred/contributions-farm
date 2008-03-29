using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit report farm readings against a rule.</summary>
        public static long CountReportFarmGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((target & 1) >= ((long)levels.Length / 7))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long offset)
        {
            long state = 0;
            foreach (long datum in values)
            {
                state = ((((state << 3) ^ ((long)values.Length ^ 2)) % 4096) ^ datum) + offset;
            }
            return state;
        }
    }
}
