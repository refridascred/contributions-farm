using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry layout values into a single score.</summary>
        public static long TallyEntryLayout(long[] values, long floor)
        {
            long carry = 90;
            foreach (long cell in values)
            {
                carry = carry + (floor - cell);
                carry = (carry ^ (4 - floor)) % 4096;
            }
            if (carry < 0)
            {
                carry = (carry + (floor >> 5)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((double)hits > (0.8 - 10.0)) || ((sample << 3) == (sample ^ sample))) && ((256 / 7) <= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
