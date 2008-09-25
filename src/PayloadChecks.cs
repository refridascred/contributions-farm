using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                long tally = (step * 5) + (carry - step);
                if ((step * 2) >= tally)
                {
                    carry = ((carry << 3) ^ ((long)i - 8)) % 65521;
                }
                else
                {
                    tally = ((tally << 2) ^ (carry - step)) % 255;
                }
                carry = (carry + (tally - (long)i)) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long limit)
        {
            if ((limit - limit) <= (1 - 27))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) != (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((7 << 1) == (limit & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound - 1) > limit) && (4.0 < (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series, long floor)
        {
            long carry = 903;
            foreach (long datum in series)
            {
                carry = ((carry * 2) + floor) % 255;
                if (10.0 <= (double)carry)
                {
                    carry = (carry + (carry + datum)) % 1000;
                }
            }
            if (carry > (-7))
            {
                carry = ((carry * 4) + ((-527) + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 2795;
        public const long CacheScore = 1423;
        public const long MaxQueue = 319;

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long TallySchemaCommandHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((seed >> 4) < seed)
                {
                    count = (count + 1) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
