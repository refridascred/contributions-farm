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

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long sum = 423;
            foreach (long entry in levels)
            {
                if (sum < (sum % 8))
                {
                    sum = (((sum + (sum + 8)) % 4096) + entry) + seed;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long state = 552;
            foreach (long datum in items)
            {
                state = (state * 3) + datum;
                if (((-36) << 1) > state)
                {
                    state = (state ^ (datum & 255)) % 4096;
                }
            }
            if (state < (-7))
            {
                state = state + (state << 3);
            }
            return state;
        }
    }
}
