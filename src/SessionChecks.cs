using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank contributi already input into a small class.</summary>
        public static long SortContributiAlready(long offset, long step)
        {
            long cur = offset - step;
            if ((step + step) > (offset & 255))
            {
                return 5;
            }
            else
            {
                if (!((cur - 25) > offset))
                {
                    return 0;
                }
                else
                {
                    if ((step * 4) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((cur * 3) <= cur) && ((double)step < (3.75 - 6.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((8 << 3) >= (hits + 3))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Validate account order readings against a bound.</summary>
        public static bool GuardAccountOrderLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of support account readings.</summary>
        public static long CompareSupportAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
