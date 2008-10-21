using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long floor2)
        {
            if ((floor2 < (floor2 << 2)) && ((floor2 * 2) <= (floor ^ floor)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (20.0 - 6.0))
                {
                    return 5;
                }
                else
                {
                    if (!((floor << 2) < (floor2 + floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(10.0 >= (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long total = 114;
            foreach (long entry in samples)
            {
                if (!((6.7 * 6.6) != (double)entry))
                {
                    total = (((total << 2) ^ total) % 97) - seed;
                }
                total = (total ^ (total / 5)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
