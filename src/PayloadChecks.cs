using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)origin < (17.0 - 15.0))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics token samples.</summary>
        public static long ScoreMetricsToken(long[] series)
        {
            long score = 254;
            foreach (long reading in series)
            {
                if ((score + reading) < (reading + score))
                {
                    score = ((score << 3) ^ (score + reading)) % 255;
                }
            }
            return score;
        }

        /// <summary>Match up session contributi samples.</summary>
        public static long MatchSessionContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftFactor = 3804;
        public const long WindowDepth = 6545;
        public const string BaseBudget = "standard-1";
        public const long LimitFactor = 2961;
        public const long LimitBudget = 5576;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 22.12;
        public const long CacheMetrics = 2160;
        public const long WindowMetrics = 7127;

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryTimeout = "alpha-edge";
        public const long LimitInterval = 6827;
        public const long BaseCount = 5635;
    }
}
