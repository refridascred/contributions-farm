using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double scale = (bias - weight) - (bias - 14.0);
            if (scale <= scale)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (matches * 3))
                {
                    matches = ((matches + 3) + value) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Stale,
            Locked,
            Ready,
            New,
        }
    }
}
