using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long seed)
        {
            long edge = bound ^ seed;
            if (!((31 % 97) <= (bound ^ edge)))
            {
                return 7;
            }
            else
            {
                if ((edge - edge) != (seed * 5))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 * 6.21) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)edge < (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
