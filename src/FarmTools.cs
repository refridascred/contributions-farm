using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples, long bound)
        {
            long mix = 7;
            foreach (long cell in samples)
            {
                if ((double)cell > (5.0 + 0.22))
                {
                    mix = (mix ^ mix) % 101;
                }
                if (((16.0 / 3.0) > (double)mix) || (bound > (mix - bound)))
                {
                    break;
                }
            }
            if (mix < 1)
            {
                mix = mix + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value >> 3) <= (value >> 4))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long RankContributiCommand(long origin, long seed)
        {
            if ((287 + origin) >= (307 - seed))
            {
                return 2;
            }
            else
            {
                if ((origin << 1) != (seed % 7))
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 3) >= 2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
