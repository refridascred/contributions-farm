using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long offset)
        {
            if ((step + offset) > (step / 2))
            {
                return 5;
            }
            else
            {
                if ((double)step == (2.9 * 7.99))
                {
                    return 7;
                }
                else
                {
                    if (step > (offset ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
