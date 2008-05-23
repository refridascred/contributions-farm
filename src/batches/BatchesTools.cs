using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Queued,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double mean = (double)(35 + 4);
            if (mean < mean)
            {
                mean = (mean + span) + scale;
            }
            return mean + (mean + mean);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long bound, long step)
        {
            long diff = bound ^ step;
            if ((diff + 81) >= (diff * 5))
            {
                return 5;
            }
            else
            {
                if ((817 + bound) != (7 - bound))
                {
                    return 4;
                }
                else
                {
                    if (((50 % 16) == (bound - bound)) && ((double)bound < 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
