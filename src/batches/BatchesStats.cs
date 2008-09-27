using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of record notes readings.</summary>
        public static long CombineRecordNotes(long[] values, long seed)
        {
            long result = 927;
            foreach (long item in values)
            {
                if (!((double)result == (4.55 * 6.9)))
                {
                    result = ((result ^ (item + result)) % 65521) - seed;
                }
            }
            return result;
        }

        /// <summary>Derive the next editor report value from a seed.</summary>
        public static long IterateEditorReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((147 + (long)i) != (limit & 15)))
                {
                    acc = (acc - (long)i) % 97;
                    break;
                }
                if ((acc / 8) != (limit % 10))
                {
                    long gap = (805 ^ (long)i) + limit;
                    acc = (acc << 3) ^ gap;
                }
                else
                {
                    long count = limit;
                    acc = (acc - (count + 854)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
