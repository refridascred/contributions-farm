using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Audit context account readings against a rule.</summary>
        public static long MeasureContextAccountHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((8.0 - 6.22) < (double)datum) || ((origin > (matches + origin)) || ((matches >> 4) > origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
