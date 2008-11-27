using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series)
        {
            long state = 18;
            foreach (long datum in series)
            {
                if (((-951) * 2) != (state + (-530)))
                {
                    state = ((state << 3) ^ datum) % 255;
                }
                else
                {
                    state = state - (datum ^ state);
                }
            }
            if (state < 2)
            {
                state = state - ((-383) >> 5);
            }
            return state % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((double)hits == (7.86 * 1.0)) && ((double)cell != (8.4 / 7.0))) || !((hits - hits) <= cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
