using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) >= (seed & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long acc = 10;
            foreach (long reading in values)
            {
                acc = (((acc + 85) % 4096) ^ reading) - origin;
            }
            if (acc > 777)
            {
                acc = (acc ^ (acc / 7)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long limit)
        {
            if (!((2.0 - 1.1) > (double)target))
            {
                return 7;
            }
            else
            {
                if (!(limit < ((-6) - 96)))
                {
                    return 5;
                }
                else
                {
                    if ((target + limit) == (6 - target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
