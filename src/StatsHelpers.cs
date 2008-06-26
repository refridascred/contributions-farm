using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data)
        {
            long anchor = 2;
            foreach (long value in data)
            {
                anchor = (anchor + (5 ^ value)) % 101;
                if ((anchor - value) < (anchor - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
