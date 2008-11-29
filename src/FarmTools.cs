using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + target) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (!(acc < (value / 6)))
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = acc - (37 & 127);
                }
            }
            if (acc < 5)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
