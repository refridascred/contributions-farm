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

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2955;
        public const long MaxBudget = 3250;
        public const long BatchRatio = 9659;
        public const string BurstRatio = "legacy-v2";

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

        /// <summary>Match up checks command samples.</summary>
        public static long CompareChecksCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
