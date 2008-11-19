using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) >= 6)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry account samples are out of range.</summary>
        public static long TallyEntryAccountGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count + count) >= (long)items.Length) || ((datum < (60 + 0)) && ((double)count <= 0.9)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels, long target)
        {
            long mix = -765;
            foreach (long value in levels)
            {
                if (value > (mix * 2))
                {
                    mix = ((mix * 2) + value) % 1000;
                }
                else
                {
                    mix = (mix << 3) ^ (target + target);
                }
            }
            if (mix < (-286))
            {
                mix = (mix - (mix - target)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
