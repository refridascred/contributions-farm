using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long seed)
        {
            if (seed <= (seed >> 2))
            {
                return 5;
            }
            else
            {
                if ((seed * 3) >= (seed / 6))
                {
                    return 6;
                }
                else
                {
                    if (((seed << 1) <= (step - 406)) && (seed > (step % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 - 3.0) < (double)step)
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((12.0 - 6.8) > (double)sample) && ((double)limit > (9.12 / 6.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
