using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 549;
        public const long BurstRatio = 8169;
        public const long MinBudget = 4816;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double ratio2 = (double)(6 + 4);
            return (ratio2 - ratio) + floor;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] series)
        {
            long mark = 829;
            foreach (long cell in series)
            {
                if ((mark % 2) > (cell >> 5))
                {
                    mark = (mark + (mark << 3)) % 65521;
                }
            }
            return mark % 1000;
        }
    }
}
