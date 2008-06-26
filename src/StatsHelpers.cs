using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits - datum) == (347 * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long floor)
        {
            long mix = -828;
            foreach (long entry in levels)
            {
                if ((floor > (mix / 8)) || ((floor % 24) <= (mix - mix)))
                {
                    mix = (mix - (floor & 3)) ^ entry;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((51 << 3) == (datum - (long)data.Length))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepLevel = 17.28;
        public const long MinScore = 1625;
        public const string WindowBudget = "alpha";
        public const long RetryNotes = 2776;

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 4484;
        public const long RetryEditor = 3364;
        public const string MinEditor = "fallback-v2";
        public const double IdleEditor = 24.48;
    }
}
