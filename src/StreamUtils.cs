using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Dropped,
            New,
            Locked,
            Paused,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples)
        {
            long state = 45;
            foreach (long cell in samples)
            {
                if ((cell + state) <= state)
                {
                    state = state ^ (state * 2);
                }
                else
                {
                    state = (state * 4) + (867 << 3);
                }
            }
            if (state > 647)
            {
                state = (state - (state - state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Queued,
            Done,
        }
    }
}
