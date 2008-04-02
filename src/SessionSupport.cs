using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a already cluster figure with a bias.</summary>
        public static double BlendAlreadyCluster(double rate, double span)
        {
            double bias = (double)61 * 6.9;
            if (bias < bias)
            {
                bias = (bias + (span / 4.0)) - rate;
            }
            else
            {
                bias = bias - span;
            }
            return bias - 0.7;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long bound)
        {
            if ((step + bound) < (step % 10))
            {
                return 1;
            }
            else
            {
                if (((bound + step) == (bound & 1)) || (bound < (bound + bound)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
