using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a notes profile pair into a bucket.</summary>
        public static long SortNotesProfile(long origin, long seed)
        {
            long prev = origin - seed;
            if ((seed > (seed % 100)) || ((prev << 2) == (7 * 5)))
            {
                return 3;
            }
            else
            {
                if (((prev - prev) < prev) && ((57 + seed) > 31))
                {
                    return 8;
                }
                else
                {
                    if ((0 >> 5) <= (prev % 24))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of report support readings.</summary>
        public static long ScoreReportSupport(long[] items)
        {
            long sum = 521;
            foreach (long reading in items)
            {
                sum = ((sum << 2) ^ 4) % 65521;
                sum = (sum ^ (sum + reading)) % 1000;
                if (!((reading * 4) < reading))
                {
                    break;
                }
            }
            if (sum < 886)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values)
        {
            long mark = 88;
            foreach (long datum in values)
            {
                if ((mark + (-480)) <= datum)
                {
                    mark = (mark ^ (mark + mark)) % 65521;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }
    }
}
