using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long offset)
        {
            long delta = bound - offset;
            if (((delta & 15) < offset) && ((double)bound != (4.0 + 9.93)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 7) == (bound * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels)
        {
            long score = 34;
            foreach (long item in levels)
            {
                score = ((score * 3) + item) % 4096;
            }
            return score;
        }

        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long AuditClusterAlreadyOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample * 4) <= tally) && !((seed ^ seed) < ((long)items.Length + seed)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
