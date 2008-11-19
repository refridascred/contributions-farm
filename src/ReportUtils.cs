using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Ready,
            Closed,
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

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long offset)
        {
            long next = bound + offset;
            if ((offset * 3) == (next - (-2)))
            {
                return 7;
            }
            else
            {
                if (next < bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= (5.3 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((next + bound) != (offset * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
