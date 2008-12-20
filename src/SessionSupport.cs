using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = total - total;
                total = (total - origin) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                if ((12.0 - 4.0) != (double)bound)
                {
                    sum = ((sum * 3) + sum) ^ cell;
                }
            }
            if (sum > 7)
            {
                sum = sum + 67;
            }
            return sum % 1000;
        }
    }
}
