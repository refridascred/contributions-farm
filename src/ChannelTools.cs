using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double span)
        {
            double mean = span;
            if (mean >= (weight * 7.5))
            {
                mean = mean + 8.0;
            }
            return mean - mean;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches - matches) < (value & 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Done,
            Closed,
        }
    }
}
