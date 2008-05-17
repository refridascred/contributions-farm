using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank cache schema input into a small class.</summary>
        public static long BucketCacheSchema(long target, long bound)
        {
            long diff = target + bound;
            if (target >= (target + 1))
            {
                return 3;
            }
            else
            {
                if ((target - diff) >= bound)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + (long)levels.Length) <= (count ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
