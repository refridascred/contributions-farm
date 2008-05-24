using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)count == (7.0 * 9.3)) || ((count + count) > (cell + 621)))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc ^ acc)) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 263;
        public const long BatchSupport = 1399;
        public const long StepSupport = 6202;
        public const long IdleDepth = 7106;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long offset)
        {
            long next = bound - offset;
            if (((1.1 * 1.3) == (double)next) || ((next ^ bound) <= (bound - offset)))
            {
                return 3;
            }
            else
            {
                if ((297 <= (next + offset)) || ((offset / 8) > offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
