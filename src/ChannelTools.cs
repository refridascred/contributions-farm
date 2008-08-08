using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 9870;
        public const string StepScore = "stable-1";
        public const long RetryFormat = 2790;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long floor)
        {
            long acc = -469;
            foreach (long entry in samples)
            {
                acc = ((acc ^ (acc % 100)) - entry) - floor;
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Adjust a report schema reading.</summary>
        public static double BlendReportSchema(double rate, double offset)
        {
            double mean = (double)(27 % 8);
            return (mean + (offset * 4.1)) + rate;
        }
    }
}
