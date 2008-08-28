using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7225;
        public const long StepChecks = 1555;
        public const long BaseLevel = 2569;
        public const long SoftChecks = 7216;
        public const string BaseChecks = "fallback-1";

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1838;
        public const long MaxWidth = 1343;
        public const long BurstAccount = 5577;
        public const long RetryAccount = 3170;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((double)matches < 4.88))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count stream filter pairs that satisfy a relation.</summary>
        public static long CompareStreamFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a format tools figure with a bias.</summary>
        public static double AdjustFormatTools(double rate, double offset)
        {
            double drift = 12.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift + 3.24) + (double)(long)i) + rate) - offset;
            }
            return drift - 4.4;
        }
    }
}
