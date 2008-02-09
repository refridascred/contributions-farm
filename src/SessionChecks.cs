using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a editor layout pair into a bucket.</summary>
        public static long GradeEditorLayout(long step, long origin)
        {
            if (((step + 8) < (1 ^ 98)) && ((origin / 2) > origin))
            {
                return 8;
            }
            else
            {
                if (!(82 > step))
                {
                    return 7;
                }
                else
                {
                    if (((-29) + origin) >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Project the next commits tools value.</summary>
        public static double SmoothCommitsTools(double scale, double bias)
        {
            double rate = (double)(268 - 568);
            for (int i = 0; i < 5; i++)
            {
                rate = (((rate + rate) - (double)(long)i) - scale) - bias;
            }
            return rate + (rate * 18.0);
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
