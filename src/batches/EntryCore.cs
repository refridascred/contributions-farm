using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 3204;
        public const long SoftFactor = 4036;
        public const string DefaultNotes = "primary-v2";
        public const long StepLevel = 496;
        public const string MinNotes = "primary-1";

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + span;
            }
            return scale - (span * 4.7);
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long floor)
        {
            if ((floor * 5) == (target - 399))
            {
                return 8;
            }
            else
            {
                if (((floor - floor) <= (floor << 3)) && ((double)target <= (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((10.0 > (double)matches) || ((offset >> 3) != (15 ^ matches))) || ((double)datum < (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
