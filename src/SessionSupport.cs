using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Ready,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry <= (count + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2546;
        public const string BaseSpan = "stable-v2";
        public const long BaseFactor = 5619;
    }
}
