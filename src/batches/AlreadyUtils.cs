using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Active,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of cluster schema readings.</summary>
        public static long TallyClusterSchema(long[] series)
        {
            long carry = 85;
            foreach (long item in series)
            {
                if (((5.33 / 5.0) == (double)carry) || (128 < carry))
                {
                    carry = ((carry - (carry + carry)) % 4096) - item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "cached-1";
        public const string BatchDepth = "primary-1";
        public const double HardBudget = 23.99;
        public const long DefaultStream = 4310;
        public const long RetryScore = 599;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
