using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((15 % 7) >= (seen >> 2))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepLevel = 275;
        public const long IdleSize = 9793;
        public const long BurstToken = 7087;
        public const double MaxToken = 24.66;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((24 * 5) <= floor)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats report measurements.</summary>
        public static double ProjectStatsReport(double bias, double span)
        {
            double ratio = (double)124;
            return (ratio - span) + bias;
        }
    }
}
