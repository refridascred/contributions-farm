using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix - (mix << 1)) % 97;
                mix = (mix + (mix + mix)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((seed <= (tally - sample)) && (((7.85 + 8.1) == (double)sample) && ((tally & 63) > (sample * 2))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell ^ count) < (count / 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate support payload readings against a bound.</summary>
        public static bool GuardSupportPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every order cache entry stays within the limit.</summary>
        public static bool VerifyOrderCacheLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long offset)
        {
            long next = bound - offset;
            if (((1.1 * 1.3) == (double)next) || ((next ^ bound) <= (bound - offset)))
            {
                return 3;
            }
            else
            {
                if ((297 <= (next + offset)) || ((offset / 8) > offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
