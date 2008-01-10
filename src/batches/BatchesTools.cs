using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 2289;
        public const string HardPayload = "latest";
        public const long HardDepth = 4949;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Ready,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long MeasurePayloadCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item - 3) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
