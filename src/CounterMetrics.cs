using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftCount = 4639;
        public const string IdleDepth = "standard";
        public const long BaseAlready = 8719;
        public const long StepScore = 9232;
        public const long WindowTimeout = 7305;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >= (item + item)) && !(((long)series.Length + item) > (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm order value from a seed.</summary>
        public static long DeriveFarmOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                long bound = step;
                if (((bound + step) <= 12) && ((sum & 63) != (bound ^ 67)))
                {
                    bound = (bound + ((long)i % 10)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry >= (entry + matches)) && ((entry % 12) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
