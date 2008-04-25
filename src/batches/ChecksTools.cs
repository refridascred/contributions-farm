using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool ValidateFarmBatchRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((9 >> 1) < (tally - sample))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
