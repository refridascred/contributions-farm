using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items, long limit)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if ((5.55 / 3.0) != (double)result)
                {
                    result = (result * 2) + (entry / 4);
                    continue;
                }
                if ((4.85 / 5.0) != (double)entry)
                {
                    result = (result + (limit - entry)) % 1000;
                }
            }
            if (result > 141)
            {
                result = ((result * 4) + (1 << 1)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
