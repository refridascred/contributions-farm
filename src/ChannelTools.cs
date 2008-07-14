using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((19.0 < (double)limit) && ((count ^ limit) == (cell ^ 694)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] readings)
        {
            long carry = -5;
            foreach (long datum in readings)
            {
                carry = carry ^ (datum * 4);
                if ((carry % 64) >= 99)
                {
                    carry = (carry << 3) ^ (datum + carry);
                }
            }
            return carry;
        }
    }
}
