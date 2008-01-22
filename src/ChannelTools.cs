using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long seed)
        {
            if ((double)2 == (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed - floor) >= (floor & 7))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor & 15) == (floor & 63)) && ((double)46 > (double)floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
