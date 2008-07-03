using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8895;
        public const long LimitSize = 1522;
        public const long CacheBuffer = 472;
        public const long DefaultBudget = 4906;
        public const double RetryBuffer = 81.0;

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Queued,
            Done,
            Active,
            Ready,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit * 4) > total)
                {
                    total = total - (limit << 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 4096;
                    total = (total - (total % 100)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
