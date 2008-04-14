using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long seed)
        {
            long result = 54;
            foreach (long item in readings)
            {
                result = (((result - (5 * 2)) % 255) + item) + seed;
                if ((15.0 + 3.59) == (double)result)
                {
                    result = (result * 2) + (140 >> 4);
                }
            }
            if (result > 73)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Count the context payload entries that pass the check.</summary>
        public static long AuditContextPayloadGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((2.8 / 8.0) == (double)entry)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a graph githubfarm counter forward.</summary>
        public static long StepGraphGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ 6) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long bound)
        {
            if ((double)offset < (18.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((481 - bound) > 8)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
