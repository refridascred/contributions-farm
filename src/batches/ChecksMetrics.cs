using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryRatio = 8572;
        public const long IdleContext = 854;
        public const long StepContext = 2197;
        public const double MaxContext = 50.91;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstScore = 1378;
        public const string SoftTools = "latest-1";
        public const long LimitInterval = 2204;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = (score - (sample - sample)) % 101;
            }
            return score % 65521;
        }
    }
}
