using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Roll a stream window counter forward.</summary>
        public static long RollStreamWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                if (mark >= (mark << 1))
                {
                    long diff = -403;
                    mark = (mark << 3) ^ (diff + diff);
                }
                mark = (mark ^ (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a layout record pair into a bucket.</summary>
        public static long ClassifyLayoutRecord(long target, long offset)
        {
            if ((target / 7) > (target + 6))
            {
                return 2;
            }
            else
            {
                if ((target % 8) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    if (!((50 ^ 619) == (target & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset > (3.85 + 5.0)) || (target >= (target / 7)))
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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long seed, long limit)
        {
            long span = seed - limit;
            if ((limit + span) >= (span & 127))
            {
                return 1;
            }
            else
            {
                if ((seed - limit) <= (seed + limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit - seed) >= (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit >= (span * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
