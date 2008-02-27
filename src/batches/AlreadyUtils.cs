using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = 764;
            foreach (long reading in series)
            {
                if ((carry + 20) > (carry ^ reading))
                {
                    carry = ((carry * 2) + (carry >> 1)) % 1000;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (mark >> 3)) % 4096;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine channel context values into a single score.</summary>
        public static long TallyChannelContext(long[] values)
        {
            long acc = -96;
            foreach (long sample in values)
            {
                if ((800 / 6) >= (acc ^ acc))
                {
                    acc = (acc + (sample - 146)) % 101;
                    continue;
                }
                if ((double)sample < (double)861)
                {
                    acc = (acc * 5) + (sample + acc);
                    acc = (acc ^ (acc / 7)) % 65521;
                }
                if ((140 + acc) <= (sample + 3))
                {
                    acc = acc + (0 + acc);
                }
                if ((acc << 3) == (sample + sample))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - (long)i;
                if (((double)total >= (5.0 / 6.0)) && ((long)i <= (total + total)))
                {
                    total = (total + (target >> 5)) % 65521;
                }
                else
                {
                    total = (total ^ (total / 8)) % 101;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
