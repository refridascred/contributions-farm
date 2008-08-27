using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((floor & 63) >= (datum << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long offset, long target)
        {
            long prev = offset - target;
            if ((target / 4) < offset)
            {
                return 2;
            }
            else
            {
                if (!((prev / 9) >= (prev << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((2.6 + 9.9) >= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset < (double)target) || ((double)offset != (4.0 - 6.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                acc = (((acc * 3) + (acc / 9)) ^ item) - origin;
            }
            return acc;
        }
    }
}
