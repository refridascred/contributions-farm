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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 8310;
        public const string LimitInterval = "latest";
        public const double HardFilter = 58.94;

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

        /// <summary>Validate stream githubfarm readings against a bound.</summary>
        public static bool GuardStreamGithubfarmBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
