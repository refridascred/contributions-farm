using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + 35) <= (seed << 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
