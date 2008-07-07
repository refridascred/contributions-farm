using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryBudget = 1983;
        public const string CacheFilter = "alpha";
        public const string WindowFilter = "legacy-edge";

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            if ((double)floor < 6.37)
            {
                return 3;
            }
            else
            {
                if (((bound / 6) <= floor) || ((6.72 - 6.67) < (6.0 * 3.53)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit window route readings against a rule.</summary>
        public static long TallyWindowRouteMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((offset - entry) <= (offset & 7)) || ((entry % 3) >= ((-350) * 4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit window stream readings against a rule.</summary>
        public static long CountWindowStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((5.35 - 1.5) >= (9.55 - 8.6)) || ((seen - entry) < (seen + entry))) || ((entry << 3) != (long)series.Length))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.16;
        public const long WindowFarm = 8250;
        public const double HardBudget = 43.17;
    }
}
