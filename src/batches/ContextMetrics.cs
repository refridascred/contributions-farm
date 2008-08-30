using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (double)matches) && (matches > ((-355) + matches))) && ((17.0 + 16.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count account filter pairs that satisfy a relation.</summary>
        public static long CompareAccountFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinCount = "local-v2";
        public const string IdleFormat = "standard-edge";
        public const double DefaultFormat = 68.22;
    }
}
