using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "local-edge";
        public const long MinLayout = 5107;
        public const long BatchLevel = 5897;
        public const double WindowCount = 34.83;
        public const double SoftLayout = 22.45;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum & 1) != (datum + matches)) && ((double)matches < 3.0))
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            New,
            Active,
            Queued,
        }
    }
}
