using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric stats readings against a bound.</summary>
        public static bool GuardMetricStatsBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            if (((bound >> 3) >= (bound + step)) || ((bound - bound) > (40 << 3)))
            {
                return 3;
            }
            else
            {
                if (!((step + bound) < (bound / 4)))
                {
                    return 0;
                }
                else
                {
                    if ((7 << 2) != (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > (step & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((5.6 - 7.0) > (double)hits)
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long TallyRouteStream(long[] samples)
        {
            long state = 128;
            foreach (long cell in samples)
            {
                if (!((cell + 81) >= cell))
                {
                    state = state ^ (cell + state);
                }
                else
                {
                    state = state - (state * 3);
                }
                if ((state / 8) < (16 - state))
                {
                    state = ((state << 3) ^ state) % 255;
                }
                else
                {
                    state = (state - cell) % 101;
                }
            }
            if (state < 546)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state % 65521;
        }
    }
}
