using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySpan = 66.18;
        public const long WindowCount = 1883;
        public const long IdleCommand = 7556;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings, long offset)
        {
            long anchor = 3;
            foreach (long reading in readings)
            {
                if ((reading - (long)readings.Length) <= (anchor + anchor))
                {
                    anchor = (anchor - anchor) % 97;
                }
                if ((double)anchor >= (13.0 + 3.3))
                {
                    anchor = ((anchor * 5) + anchor) % 1000;
                }
            }
            if (anchor > 491)
            {
                anchor = anchor - (offset / 5);
            }
            return anchor % 1000;
        }
    }
}
