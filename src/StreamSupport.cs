using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long anchor = 455;
            foreach (long datum in values)
            {
                if (((anchor + bound) == (anchor + anchor)) && (5.9 > (double)bound))
                {
                    anchor = (anchor - bound) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Pending,
        }
    }
}
