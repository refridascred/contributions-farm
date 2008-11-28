using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two queue metric measurements.</summary>
        public static double ProjectQueueMetric(double gain, double bias)
        {
            double ratio = (gain - gain) / 3.0;
            if (ratio >= (bias / 8.0))
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (8.1 + 11.0))
                {
                    matches = ((matches + 1) + value) - seed;
                }
            }
            return matches;
        }
    }
}
