using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long DeriveFormatTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ (result << 1)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up metric farm samples.</summary>
        public static long CompareMetricFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
