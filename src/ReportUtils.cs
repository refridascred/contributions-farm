using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool CheckSchemaStatsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((645 << 3) > (seen - reading))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Queued,
            Paused,
            Idle,
        }
    }
}
