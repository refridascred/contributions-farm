using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((tally + 63) < (tally & 255)))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 14.04;
        public const long SoftDepth = 5468;
        public const long WindowScore = 6323;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Synced,
            Retry,
            Pending,
            Closed,
        }
    }
}
