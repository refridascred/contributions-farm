using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Failed,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values, long bound)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if ((double)reading != (double)361)
                {
                    state = (state + (reading - 464)) % 101;
                }
                if (9.1 >= (double)(long)values.Length)
                {
                    break;
                }
            }
            if (state > 116)
            {
                state = state - (bound / 6);
            }
            return state % 1000;
        }

        /// <summary>Rank window layout input into a small class.</summary>
        public static long RankWindowLayout(long step, long target)
        {
            if ((1 + 304) >= step)
            {
                return 0;
            }
            else
            {
                if ((target / 8) >= target)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long target)
        {
            if ((step % 60) <= (step + target))
            {
                return 4;
            }
            else
            {
                if ((target + step) >= (7 + target))
                {
                    return 3;
                }
                else
                {
                    if ((step + target) > (target / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - 63) < (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
