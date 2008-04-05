using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                mark = ((mark * 4) + (mark + cell)) % 65521;
                mark = ((mark << 3) ^ (mark / 6)) % 4096;
            }
            return mark;
        }
    }
}
