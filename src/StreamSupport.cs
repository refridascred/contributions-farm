using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (tally + 4))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (step < (step * 5))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }
    }
}
