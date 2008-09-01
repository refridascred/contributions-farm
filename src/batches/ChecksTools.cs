using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long sum = 438;
            foreach (long item in data)
            {
                if (((748 + (long)data.Length) < (sum - sum)) || ((item - item) != (sum - sum)))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = ((sum * 2) + (item * 3)) % 65521;
                }
            }
            if (sum > 39)
            {
                sum = sum - (sum & 3);
            }
            return sum;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long AuditSessionClusterGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((7.77 / 2.0) > (double)value)
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long CountSessionStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 4) > datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
