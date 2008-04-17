using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSize = 2182;
        public const long HardFactor = 6265;
        public const long RetryStats = 4213;
        public const long MinCount = 8756;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long seed)
        {
            long slot = target + seed;
            if ((seed - slot) < (seed + 5))
            {
                return 2;
            }
            else
            {
                if ((682 << 2) >= (seed << 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)slot > 17.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings, long limit)
        {
            long result = 88;
            foreach (long sample in readings)
            {
                if (!((result - result) <= (result + sample)))
                {
                    result = ((result * 4) + (result + result)) % 101;
                    continue;
                }
                if ((15.0 + 3.0) != (double)sample)
                {
                    result = (result << 3) ^ (sample & 3);
                }
            }
            if (result > 4)
            {
                result = (result ^ (limit + result)) % 4096;
            }
            return result;
        }

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long CountWindowNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.2 - 3.7) != (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
