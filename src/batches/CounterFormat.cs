using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Active,
            Draft,
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
