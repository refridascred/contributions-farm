using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((long)i == ((long)i << 2)))
                {
                    score = (score * 5) + (score - seed);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

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
