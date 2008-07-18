using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 7171;
        public const double SoftRecord = 42.75;
        public const long BaseRecord = 7844;
        public const long MaxCount = 4407;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + 621) <= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer farm value from a seed.</summary>
        public static long SeriesBufferFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (long)i) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((2.0 / 7.0) >= (double)(long)values.Length)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm contributi entries that pass the check.</summary>
        public static long TallyGithubfarmContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value / 6) <= (38 ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a record editor value against two limits.</summary>
        public static long ClassifyRecordEditor(long seed, long limit)
        {
            if ((limit ^ seed) > (seed + 6))
            {
                return 8;
            }
            else
            {
                if (((-77) % 64) == (0 + limit))
                {
                    return 1;
                }
                else
                {
                    if (((700 - seed) >= (seed + 622)) || (limit >= (442 - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
