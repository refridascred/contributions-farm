using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a payload buffer reading.</summary>
        public static double ProjectPayloadBuffer(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > (weight / 9.0))
            {
                weight2 = (weight2 + (weight + weight2)) - bias;
            }
            else
            {
                weight2 = weight2 - (7.9 + weight2);
            }
            return weight2 - (weight * 8.0);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((bound + cell) > (seen * 2)) && ((661 * 4) < cell)) || ((941 + seen) > (seen << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
