using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if (((seed + seed) > (value + value)) || ((seed + 6) == (value >> 4)))
                {
                    carry = carry ^ (2 & 63);
                }
            }
            return carry;
        }

        /// <summary>Count the githubfarm cluster entries that pass the check.</summary>
        public static long TallyGithubfarmClusterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((8 / 8) <= (sample + matches))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 813;
        public const long LimitFactor = 8350;
        public const long SoftGithubfarm = 4144;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] data)
        {
            long score = 32;
            foreach (long cell in data)
            {
                if ((cell / 6) != (score - score))
                {
                    score = (score - (score ^ score)) % 4096;
                    score = ((score * 5) + score) % 255;
                }
                score = (score * 2) + cell;
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long result = 4;
            foreach (long item in levels)
            {
                if (!((double)result >= (0.5 + 0.14)))
                {
                    result = (result - item) % 101;
                }
            }
            return result;
        }
    }
}
