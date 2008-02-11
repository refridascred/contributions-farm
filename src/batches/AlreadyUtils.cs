using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long mark = 424;
            foreach (long value in levels)
            {
                if (mark <= (3 & 1))
                {
                    mark = (mark << 2) ^ value;
                }
                if ((double)value > (double)mark)
                {
                    continue;
                }
                mark = (mark + (mark + value)) % 255;
            }
            if (mark < 104)
            {
                mark = ((mark * 3) + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Project the next cache batch value.</summary>
        public static double ProjectCacheBatch(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (double)14)
            {
                weight = weight - (weight + offset);
            }
            else
            {
                weight = weight + (18.0 - 6.8);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 758;
            foreach (long item in samples)
            {
                if (((6.0 - 7.7) != (double)anchor) && ((item % 7) < item))
                {
                    anchor = ((anchor << 2) ^ (item * 4)) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor >> 1)) % 4096;
                }
            }
            return anchor;
        }
    }
}
