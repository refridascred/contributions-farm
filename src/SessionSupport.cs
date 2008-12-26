using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series)
        {
            long state = -2;
            foreach (long item in series)
            {
                if ((item + state) != (item + 183))
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state * 5) + (385 & 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)seed <= 15.0)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
