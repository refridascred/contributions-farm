using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading + matches) <= (reading ^ reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long ClassifyClusterCache(long bound, long offset)
        {
            if ((double)offset >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (bound <= (8 + 50))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen << 1) >= (seen & 3)) && (seen >= cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits stats series from a seed.</summary>
        public static long IterateCommitsStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (long)i;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Active,
            Done,
        }
    }
}
