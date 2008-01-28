using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first editor githubfarm entry that matches the target.</summary>
        public static long LocateEditorGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (origin > (34 + lane))
            {
                return 6;
            }
            else
            {
                if ((origin - origin) >= (810 - origin))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 2) == (0 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4526;
        public const double BaseCommand = 47.47;
        public const double MinCommand = 54.64;
        public const long BurstLevel = 3192;
        public const long CacheBudget = 518;

        /// <summary>Audit queue format readings against a rule.</summary>
        public static long TallyQueueFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((5 << 3) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
