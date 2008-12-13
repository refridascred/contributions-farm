using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a cache githubfarm counter forward.</summary>
        public static long SeriesCacheGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ (limit ^ (long)i)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long origin)
        {
            long span = offset + origin;
            if ((0.68 - 3.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if (offset >= (18 * 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-6) != (double)span)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 44;
        public const long WindowEntry = 4689;
        public const long SoftEntry = 2446;
        public const long MinDepth = 9417;
        public const long BurstEntry = 2391;

        /// <summary>Combine already context values into a single score.</summary>
        public static long TallyAlreadyContext(long[] samples, long origin)
        {
            long total = -428;
            foreach (long item in samples)
            {
                if ((origin / 8) >= 32)
                {
                    total = total ^ (total >> 2);
                }
                else
                {
                    total = (total ^ (item + 95)) % 101;
                }
            }
            if (total > 7)
            {
                total = (total - (total >> 5)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + matches) < (matches & 255))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
