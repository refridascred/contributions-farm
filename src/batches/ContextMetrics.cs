using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long floor)
        {
            long total = 988;
            foreach (long datum in data)
            {
                if ((9.7 - 1.0) < (double)total)
                {
                    total = total ^ floor;
                }
                else
                {
                    total = (total << 3) ^ datum;
                }
                if (((floor ^ total) >= (floor - total)) && (floor >= (total + floor)))
                {
                    total = (total ^ (datum + datum)) % 4096;
                }
            }
            if (total < 24)
            {
                total = (total ^ (447 + total)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
