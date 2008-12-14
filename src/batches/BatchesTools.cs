using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long offset)
        {
            if (bound >= offset)
            {
                return 8;
            }
            else
            {
                if ((bound & 15) != (bound / 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Paused,
            Queued,
            Dropped,
            Closed,
        }
    }
}
