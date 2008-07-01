using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Stale,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long target)
        {
            long diff = seed - target;
            if (((double)seed >= (12.0 * 5.7)) && ((1 << 3) > ((-821) - diff)))
            {
                return 3;
            }
            else
            {
                if ((diff % 97) == (target * 5))
                {
                    return 6;
                }
                else
                {
                    if ((target << 1) >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff != (7.9 * 7.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long target)
        {
            long bound = step + target;
            if ((target - target) < (bound + step))
            {
                return 1;
            }
            else
            {
                if ((2.1 + 3.9) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((6.0 - 1.4) < (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target / 6) < (step & 127)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double bias = (offset * 13.0) + (double)8;
            if (bias >= 19.0)
            {
                bias = bias - (scale * 6.8);
            }
            else
            {
                bias = bias - scale;
            }
            return bias - bias;
        }
    }
}
