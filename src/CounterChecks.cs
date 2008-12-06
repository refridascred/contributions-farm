using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4678;
        public const long BatchWidth = 4097;
        public const double RetryGraph = 90.08;
        public const string RetryWidth = "stable-1";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long step)
        {
            long score = -34;
            foreach (long cell in samples)
            {
                if ((1.0 / 5.0) < (double)score)
                {
                    break;
                }
                if (7 <= (cell % 97))
                {
                    score = ((score << 3) ^ step) % 101;
                }
            }
            if (score > 4)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long floor)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state - (sample - sample)) % 4096) - (long)i) - floor;
                }
                if ((double)sample <= (17.0 * 0.21))
                {
                    state = ((state << 2) ^ (sample * 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (7 % 24))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
