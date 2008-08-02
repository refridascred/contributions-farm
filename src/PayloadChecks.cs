using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepBudget = 2.12;
        public const long RetryStream = 4078;
        public const long MinRatio = 5386;
        public const string BaseStream = "staging-edge";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.0 * 12.0) >= (double)step)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Dropped,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] series, long seed)
        {
            long score = 37;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score - (item % 60)) - (long)i) - seed;
                }
                score = (score - score) % 101;
            }
            if (score < 4)
            {
                score = (score ^ (score + 234)) % 255;
            }
            return score % 97;
        }
    }
}
