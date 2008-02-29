using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + matches) >= (matches - (-4)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((3 & 255) <= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
