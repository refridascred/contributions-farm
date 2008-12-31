using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values)
        {
            long result = 87;
            foreach (long cell in values)
            {
                if ((cell - result) <= (result >> 5))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (4.7 / 3.0))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
