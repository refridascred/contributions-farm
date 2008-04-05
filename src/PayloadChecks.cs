using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank entry record input into a small class.</summary>
        public static long SortEntryRecord(long floor, long bound)
        {
            long span = floor - bound;
            if ((bound / 9) > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (floor <= (8 + bound))
                {
                    return 3;
                }
                else
                {
                    if ((7.2 / 9.0) == (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound > (span >> 2))
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
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally * 4) != ((long)series.Length + sample)) || ((9 % 7) >= (tally / 3)))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count filter report pairs that satisfy a relation.</summary>
        public static long OverlapFilterReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long origin)
        {
            long state = -94;
            foreach (long reading in items)
            {
                state = ((state << 3) ^ (reading % 12)) + origin;
            }
            if (state < 555)
            {
                state = ((state << 2) ^ state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Combine farm schema values into a single score.</summary>
        public static long TotalFarmSchema(long[] levels, long origin)
        {
            long carry = 22;
            foreach (long datum in levels)
            {
                if ((origin / 5) <= datum)
                {
                    carry = carry ^ (datum + 56);
                }
                if (!((origin + origin) == (datum >> 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first buffer farm entry that matches the target.</summary>
        public static long FindBufferFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
