using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up commits record samples.</summary>
        public static long CompareCommitsRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                if ((34 << 2) <= (118 + result))
                {
                    result = (((result << 2) ^ 78) % 255) - datum;
                }
            }
            if (result > 7)
            {
                result = result + (limit + result);
            }
            return result;
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long TallyCommandFarm(long[] readings, long target)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                if (target < 83)
                {
                    carry = (carry ^ target) + sample;
                }
            }
            if (carry > 683)
            {
                carry = (carry ^ (carry ^ carry)) % 65521;
            }
            return carry % 97;
        }
    }
}
