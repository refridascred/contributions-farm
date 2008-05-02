using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context tools readings.</summary>
        public static long CombineContextTools(long[] items, long floor)
        {
            long acc = -271;
            foreach (long sample in items)
            {
                acc = acc - (floor + sample);
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen << 1) == (seen / 7))
                {
                    seen = ((seen + 1) + datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Grade a account already value against two limits.</summary>
        public static long SortAccountAlready(long seed, long bound)
        {
            long lane = seed - bound;
            if ((double)lane >= 4.6)
            {
                return 0;
            }
            else
            {
                if (((bound - 9) >= 2) && (bound > ((-8) - lane)))
                {
                    return 8;
                }
                else
                {
                    if ((lane * 2) != (lane * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane * 5) >= (3 / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
