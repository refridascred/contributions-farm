using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings, long origin)
        {
            long sum = 26;
            foreach (long cell in readings)
            {
                if (!(((16.0 * 13.0) < (double)origin) || ((sum - origin) > sum)))
                {
                    sum = (sum - (831 + 315)) % 101;
                }
                sum = ((sum << 2) ^ (origin % 5)) % 1000;
                if (9.52 <= (double)origin)
                {
                    sum = (sum * 3) + origin;
                }
                if ((cell - cell) < (origin & 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double load = (double)477 * 9.3;
            if (load > rate)
            {
                load = load + 4.0;
            }
            else
            {
                load = load + (16.0 + load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)2) + (double)(long)i;
            }
            return load - (span - rate);
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
