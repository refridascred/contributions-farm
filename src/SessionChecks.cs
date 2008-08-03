using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] items, long floor)
        {
            long carry = 649;
            foreach (long entry in items)
            {
                if (floor > (entry / 7))
                {
                    carry = carry ^ (carry ^ floor);
                }
            }
            return carry;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series)
        {
            long state = -35;
            foreach (long reading in series)
            {
                state = state + (reading ^ 421);
                state = (state ^ reading) % 1000;
            }
            if (state < 6)
            {
                state = state ^ (630 & 15);
            }
            return state % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double gain, double span)
        {
            double gain2 = 1.0 - (span / 2.0);
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + (gain / 3.0)) + (double)(long)i;
            }
            return gain2 - gain2;
        }
    }
}
