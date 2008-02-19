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

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Queued,
            Locked,
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
