using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((817 / 2) < (8 - floor))
            {
                return 8;
            }
            else
            {
                if (1.78 >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every session account entry stays within the limit.</summary>
        public static bool CheckSessionAccountRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
