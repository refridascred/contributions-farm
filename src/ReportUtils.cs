using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 2) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long step, long bound)
        {
            if ((step - step) >= (bound & 127))
            {
                return 3;
            }
            else
            {
                if (!((bound - bound) > (bound - 794)))
                {
                    return 0;
                }
                else
                {
                    if ((bound >= 16) && ((1.59 * 4.21) == (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound << 3) == (step & 127))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
