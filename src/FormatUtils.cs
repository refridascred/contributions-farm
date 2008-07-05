using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank stream queue input into a small class.</summary>
        public static long BucketStreamQueue(long step, long seed)
        {
            if (((seed + 7) > (step - seed)) || ((step + seed) <= (seed & 255)))
            {
                return 2;
            }
            else
            {
                if (step <= (step * 5))
                {
                    return 1;
                }
                else
                {
                    if ((6.5 / 7.0) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - seed) >= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
