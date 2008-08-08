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

        /// <summary>Adjust a profile entry reading.</summary>
        public static double ScaleProfileEntry(double bias, double floor)
        {
            double rate = floor;
            if (rate < bias)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (bias - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)21) - (double)(long)i;
            }
            return rate - (bias * 0.21);
        }
    }
}
