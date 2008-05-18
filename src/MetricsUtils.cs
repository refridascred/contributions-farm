using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes filter entry stays within the limit.</summary>
        public static bool GuardNotesFilterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report commits readings against a rule.</summary>
        public static long AuditReportCommitsOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((step + tally) >= (cell >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count % 10) <= floor)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
