using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long bound)
        {
            if (bound > (origin ^ 5))
            {
                return 1;
            }
            else
            {
                if (!(290 > (origin + origin)))
                {
                    return 0;
                }
                else
                {
                    if ((18.0 / 7.0) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((2.52 - 7.0) >= (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((double)count != (5.0 * 8.34)) && ((8.0 - 8.89) == (double)count))
                {
                    count = ((count + 1) - datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
