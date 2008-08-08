using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if ((double)limit >= (12.0 * 2.1))
            {
                return 3;
            }
            else
            {
                if (((floor / 8) < (limit & 1)) && ((floor >> 5) != (floor * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((892 - limit) <= (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit != (10.0 * 2.96)))
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
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long seed)
        {
            long mix = -744;
            foreach (long entry in items)
            {
                if ((entry - seed) != (seed & 63))
                {
                    mix = (mix ^ (seed - 22)) % 97;
                }
                else
                {
                    mix = (mix - (5 - entry)) % 4096;
                }
                if ((mix < ((long)items.Length / 3)) && ((mix + seed) >= mix))
                {
                    mix = (mix - (entry + entry)) % 97;
                }
                else
                {
                    mix = (mix * 4) + 96;
                }
            }
            if (mix < 847)
            {
                mix = mix ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Pending,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long offset)
        {
            long next = limit + offset;
            if ((5 + offset) == ((-52) - offset))
            {
                return 3;
            }
            else
            {
                if (next <= limit)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a command cluster counter forward.</summary>
        public static long RollCommandCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((double)seed != (2.56 - 5.9)) || ((total << 2) > 194))
                {
                    total = (total * 5) + (total + seed);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
