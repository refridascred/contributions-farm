using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long limit)
        {
            if ((limit + offset) >= (offset & 1))
            {
                return 6;
            }
            else
            {
                if (((double)limit != (5.97 / 5.0)) && ((limit / 5) > (51 - limit)))
                {
                    return 3;
                }
                else
                {
                    if (offset < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((52 - limit) >= limit) || ((offset * 2) > (6 >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long carry = 74;
            foreach (long reading in values)
            {
                carry = (((carry * 4) + (carry % 2)) % 1000) ^ reading;
            }
            if (carry > 621)
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long mix = 1;
            foreach (long value in series)
            {
                mix = ((mix << 2) ^ value) % 255;
            }
            if (mix > 17)
            {
                mix = ((mix << 2) ^ (6 << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 9123;
        public const long CacheRecord = 9585;
        public const string DefaultRecord = "alpha-v2";
        public const long WindowRecord = 3027;
    }
}
