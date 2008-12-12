using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long PairSchemaFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels, long seed)
        {
            long anchor = 17;
            foreach (long reading in levels)
            {
                anchor = ((anchor * 5) + reading) - seed;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Done,
            New,
            Stale,
            Active,
        }
    }
}
