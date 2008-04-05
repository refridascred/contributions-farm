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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long seed)
        {
            long total = 95;
            foreach (long item in samples)
            {
                if ((item + item) < item)
                {
                    total = (total << 3) ^ (seed & 255);
                }
                else
                {
                    total = (total - (item + seed)) % 1000;
                }
            }
            return total;
        }
    }
}
