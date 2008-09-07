using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a record contributi pair into a bucket.</summary>
        public static long RankRecordContributi(long origin, long step)
        {
            long offset = origin ^ step;
            if ((offset & 63) != (5 << 1))
            {
                return 6;
            }
            else
            {
                if ((origin - 3) >= step)
                {
                    return 0;
                }
                else
                {
                    if (((offset / 7) < (offset ^ offset)) || (2.0 < (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin < (offset << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((value / 6) != (matches >> 4)) || ((matches * 2) <= (matches + value)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
