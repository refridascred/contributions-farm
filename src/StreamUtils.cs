using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long TallyEntryProfileHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum > (823 + target)) || ((7.19 / 2.0) <= (double)target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - seen) < seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + sample) < 6)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long StepStatsToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + carry) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
