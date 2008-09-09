using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank context route input into a small class.</summary>
        public static long ClassifyContextRoute(long seed, long seed2)
        {
            if ((seed2 - seed) >= seed2)
            {
                return 7;
            }
            else
            {
                if (((seed2 + seed) >= (seed << 1)) && ((seed2 + seed) >= seed))
                {
                    return 0;
                }
                else
                {
                    if ((seed2 - 827) < seed2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed + seed) >= (seed % 97)) || ((seed2 - seed2) >= (seed - seed2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
