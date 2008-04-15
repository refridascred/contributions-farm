using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) != (579 & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long bound)
        {
            long score = 9;
            foreach (long sample in levels)
            {
                score = ((score << 2) ^ (bound * 3)) - sample;
            }
            return score;
        }
    }
}
