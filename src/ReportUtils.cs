using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + (long)i) % 65521;
                if (((620 - anchor) >= origin) && ((869 % 24) <= origin))
                {
                    anchor = anchor + (anchor + anchor);
                }
                anchor = ((anchor * 2) + 686) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long sum = -262;
            foreach (long sample in values)
            {
                if ((5.9 * 3.7) <= (double)sample)
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum ^ (sample + 8)) % 97;
                }
            }
            if (sum > 0)
            {
                sum = (sum - (sum - 558)) % 97;
            }
            return sum;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((bound2 >> 1) <= bound)
            {
                return 1;
            }
            else
            {
                if ((bound ^ next) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((6.0 + 6.6) < (double)bound2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((next << 1) != (bound ^ bound)) || ((bound2 % 10) > next))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Active,
            Dropped,
            Pending,
        }
    }
}
