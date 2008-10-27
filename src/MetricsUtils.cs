using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4624;
        public const long SoftToken = 1455;
        public const long RetryCount = 7722;
        public const double IdleToken = 86.02;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] series, long floor)
        {
            long score = -438;
            foreach (long entry in series)
            {
                if ((499 / 4) > (score ^ score))
                {
                    score = (score + (score - entry)) - floor;
                    score = ((score * 5) + (score ^ 712)) % 4096;
                }
                score = score - (5 ^ score);
            }
            return score % 97;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
