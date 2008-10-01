using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultRatio = "legacy";
        public const string BaseCommand = "local-edge";
        public const double MaxCommand = 94.58;

        /// <summary>Derive the next editor account value from a seed.</summary>
        public static long DeriveEditorAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long bound)
        {
            long next = offset + bound;
            if (!((12.0 / 8.0) <= (double)next))
            {
                return 0;
            }
            else
            {
                if ((61 - 0) < (offset + next))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((20.0 * 14.0) > (double)cell) || ((count % 7) < cell)))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
