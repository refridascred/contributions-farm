using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 4866;
        public const long HardBatch = 3648;
        public const long MinBatch = 7790;
        public const long MinFactor = 2093;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long floor)
        {
            long score = 40;
            foreach (long cell in samples)
            {
                if ((((-454) / 8) <= score) && ((floor - floor) != (score << 1)))
                {
                    score = (score + floor) + cell;
                }
                else
                {
                    score = ((score << 3) ^ (575 & 7)) % 4096;
                }
            }
            if (score < 9)
            {
                score = score - 993;
            }
            return score % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long TotalWindowTools(long[] readings, long target)
        {
            long score = 851;
            foreach (long cell in readings)
            {
                score = (((score * 4) + 91) % 4096) + cell;
                if ((7 * 3) < (target >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long TallyChannelBatchesGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + 130) <= (entry + seen))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
