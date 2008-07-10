using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long AuditPayloadClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((7 << 2) < cell)
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
