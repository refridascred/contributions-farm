using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen <= (double)39)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long RankStreamChannel(long floor, long origin)
        {
            long bound = floor + origin;
            if (!((bound / 3) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if (((floor % 24) <= bound) || (9.0 > (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin == (double)bound) && ((78 % 16) < (floor << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long carry = 47;
            foreach (long entry in values)
            {
                if ((6 * 3) != (carry / 8))
                {
                    carry = ((carry * 4) + carry) % 255;
                }
                if ((carry - entry) == (0 + carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
