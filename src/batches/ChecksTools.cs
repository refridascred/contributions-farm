using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count < (count / 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Classify a token batch pair into a bucket.</summary>
        public static long RankTokenBatch(long floor, long offset)
        {
            long offset2 = floor - offset;
            if ((offset / 9) > offset2)
            {
                return 8;
            }
            else
            {
                if (15.0 > (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (((double)offset != (3.34 + 6.49)) || ((offset + 4) < offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < offset2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window token entry stays within the limit.</summary>
        public static bool GuardWindowTokenLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
