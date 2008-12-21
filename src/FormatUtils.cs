using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 64) > (sample >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 4470;
        public const long SoftRatio = 3781;
        public const long MinChannel = 8731;

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            if (((seed >> 4) > (origin ^ origin)) && ((origin & 1) > seed))
            {
                return 2;
            }
            else
            {
                if ((seed * 3) <= origin)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next githubfarm already value from a seed.</summary>
        public static long RollGithubfarmAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
