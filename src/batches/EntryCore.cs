using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long limit)
        {
            long cur = step ^ limit;
            if (7.8 < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((92 + 644) != (limit - cur))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) == (step / 8)) && ((0 + cur) >= (limit << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the order already entries that pass the check.</summary>
        public static long CountOrderAlreadyHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum + datum) != (37 * 2)) && !((origin - datum) <= ((-61) << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Locked,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] data)
        {
            long carry = 30;
            foreach (long entry in data)
            {
                if ((entry & 63) > (989 * 4))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                if ((carry > (entry ^ (long)data.Length)) || (58 >= (89 + entry)))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
