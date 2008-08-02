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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell >= origin) && (tally <= origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
