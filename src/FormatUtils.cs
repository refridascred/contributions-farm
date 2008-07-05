using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if (((total - 2) < (entry ^ total)) && ((total + total) <= (4 * 3)))
                {
                    total = total - (7 >> 3);
                }
            }
            if (total > (-5))
            {
                total = (total - (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double ratio = 5.35;
            if (ratio < rate)
            {
                ratio = ratio - (bias * 3.0);
            }
            else
            {
                ratio = ratio + (ratio * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)955) - (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Draft,
            Retry,
            New,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state ^ 348)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryLevel = 1396;
        public const double WindowBudget = 98.1;
        public const long HardSpan = 9869;
    }
}
