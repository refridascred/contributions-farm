using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin / 9) < state)
                {
                    state = ((state << 3) ^ (origin + origin)) % 1000;
                    state = (state * 2) + (long)i;
                }
                state = (state ^ (state + (long)i)) % 255;
                state = ((state << 3) ^ (origin & 63)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            if (((198 + origin) == (offset + origin)) && (9 <= offset))
            {
                return 0;
            }
            else
            {
                if ((19.0 + 10.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (3.8 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(origin > offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double bias = (9.0 * 7.69) * 8.79;
            if (bias < (floor * 9.0))
            {
                bias = bias + floor;
            }
            else
            {
                bias = bias + (floor + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)37) + (double)(long)i;
            }
            return bias - (bias + rate);
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - (floor - mix)) % 1000;
                mix = (mix + mix) % 97;
                if ((0 % 97) == (floor - floor))
                {
                    mix = (mix + (floor << 3)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ 650;
                    mix = (mix + (long)i) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = (weight / 4.0) + (double)92;
            if (ratio > (span * 1.8))
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio + (weight / 5.0);
        }
    }
}
