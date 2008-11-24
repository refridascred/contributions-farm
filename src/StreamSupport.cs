using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            New,
            Idle,
            Pending,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((1.91 / 7.0) == (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 843) <= (reading * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
