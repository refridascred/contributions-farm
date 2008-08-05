using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many account channel samples are out of range.</summary>
        public static long AuditAccountChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if ((double)limit2 != (double)721)
            {
                return 4;
            }
            else
            {
                if (((2 & 63) <= (limit + limit)) && ((limit % 2) != (limit2 << 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit2 <= (9.7 * 4.61)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long target2)
        {
            long diff = target - target2;
            if ((target ^ target) > 56)
            {
                return 0;
            }
            else
            {
                if (!(6 <= (target2 + diff)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = (mean - (double)4) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Active,
            Failed,
        }
    }
}
