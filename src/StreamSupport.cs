using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 5) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + reading) > 3) && ((offset / 7) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
