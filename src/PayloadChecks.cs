using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (444 < (bound << 2))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits >= (3.0 * 1.5))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

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
