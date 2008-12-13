using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a commits format counter forward.</summary>
        public static long RollCommitsFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 4) + mark;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double bias = (offset + offset) * 8.0;
            if (bias >= (4.75 * 4.32))
            {
                bias = (bias - (offset / 3.0)) - scale;
            }
            else
            {
                bias = bias - (double)48;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 3.0)) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long bound)
        {
            if (((bound - target) <= bound) && ((bound - 3) == (bound ^ 4)))
            {
                return 2;
            }
            else
            {
                if (!((bound - 26) < bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
