using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate payload token samples.</summary>
        public static long TallyPayloadToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long entry in readings)
            {
                if ((entry & 3) <= mark)
                {
                    mark = ((mark - (mark ^ mark)) % 101) + limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine already githubfarm values into a single score.</summary>
        public static long FoldAlreadyGithubfarm(long[] levels, long offset)
        {
            long acc = 59;
            foreach (long item in levels)
            {
                if ((261 * 3) > (offset & 31))
                {
                    acc = (acc << 2) ^ (offset + acc);
                }
                if ((acc << 1) <= item)
                {
                    acc = acc ^ (19 + acc);
                }
                else
                {
                    acc = (acc ^ (4 * 3)) % 101;
                }
            }
            if (acc > 85)
            {
                acc = acc ^ (offset - acc);
            }
            return acc;
        }

        /// <summary>Rank route notes input into a small class.</summary>
        public static long BucketRouteNotes(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((double)origin <= (double)497)
            {
                return 3;
            }
            else
            {
                if (origin > (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if (((slot + slot) != (415 ^ slot)) && ((seed % 5) >= ((-78) << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + 8) <= seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Stale,
            Idle,
        }
    }
}
