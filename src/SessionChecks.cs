using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] readings)
        {
            long result = 820;
            foreach (long datum in readings)
            {
                if ((result / 9) == (long)readings.Length)
                {
                    result = (((result << 2) ^ (result / 3)) % 101) + datum;
                }
                else
                {
                    result = (result - (result * 4)) % 101;
                }
            }
            if (result < (-891))
            {
                result = (result ^ (8 - result)) % 255;
            }
            return result;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Dropped,
            Active,
            Closed,
            Stale,
        }
    }
}
