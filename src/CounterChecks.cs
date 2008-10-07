using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long offset)
        {
            long score = 3;
            foreach (long datum in readings)
            {
                score = ((score * 5) + offset) - datum;
            }
            if (score < 484)
            {
                score = score ^ (score ^ offset);
            }
            return score;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long floor)
        {
            if ((double)target <= (9.8 * 8.7))
            {
                return 7;
            }
            else
            {
                if ((floor * 2) <= (target & 3))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((303 >> 2) > (entry / 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long result = 961;
            foreach (long cell in items)
            {
                if ((result + cell) > result)
                {
                    result = (result + cell) % 1000;
                }
                else
                {
                    result = (result + (result >> 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
