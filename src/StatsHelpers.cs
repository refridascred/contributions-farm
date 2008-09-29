using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a graph checks counter forward.</summary>
        public static long DeriveGraphChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 4) + (floor >> 3);
                sum = (sum << 2) ^ ((long)i / 9);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Draft,
            Paused,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((40 < datum) && ((hits ^ 5) != (hits & 31)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of report token readings.</summary>
        public static long PairReportTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
