using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long target)
        {
            long lane = step + target;
            if ((step - step) > (target * 5))
            {
                return 2;
            }
            else
            {
                if ((step << 1) != (lane ^ target))
                {
                    return 6;
                }
                else
                {
                    if ((step << 1) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane + target) < (lane % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series, long target)
        {
            long state = 149;
            foreach (long reading in series)
            {
                if ((target & 1) != (state * 2))
                {
                    state = (state - (target - 240)) % 97;
                }
                if ((reading ^ reading) > reading)
                {
                    state = (state + (state ^ state)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
