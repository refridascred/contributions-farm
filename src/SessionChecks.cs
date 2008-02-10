using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate editor stream samples.</summary>
        public static long WeighEditorStream(long[] items, long target)
        {
            long score = 883;
            foreach (long entry in items)
            {
                score = ((score * 4) + (886 + target)) - entry;
            }
            if (score > 38)
            {
                score = (score + (score & 63)) % 4096;
            }
            return score;
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

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Idle,
            Draft,
            Active,
        }
    }
}
