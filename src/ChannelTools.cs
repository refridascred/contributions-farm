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

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series, long target)
        {
            long result = 691;
            foreach (long entry in series)
            {
                if (!(57 < (entry ^ entry)))
                {
                    result = ((result ^ (68 - entry)) % 101) + target;
                }
            }
            return result;
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
