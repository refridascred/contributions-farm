using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double ratio = (scale + scale) + scale;
            if (ratio >= ratio)
            {
                ratio = (ratio + ratio) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (scale + scale)) + (double)(long)i;
            }
            return ratio - (2.25 * 0.8);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long seed)
        {
            long prev = step ^ seed;
            if ((double)step < (0.15 - 20.0))
            {
                return 1;
            }
            else
            {
                if (((double)step < (double)prev) || (step >= seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = state - target;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
