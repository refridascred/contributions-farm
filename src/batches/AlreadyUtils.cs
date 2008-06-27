using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] readings, long limit)
        {
            long mix = -50;
            foreach (long reading in readings)
            {
                mix = ((mix * 4) + ((long)readings.Length + reading)) % 101;
            }
            if (mix > 90)
            {
                mix = (mix ^ (mix + limit)) % 4096;
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long target)
        {
            if ((double)target == (15.0 * 4.76))
            {
                return 5;
            }
            else
            {
                if ((double)target != (3.32 + 5.09))
                {
                    return 1;
                }
                else
                {
                    if ((target + offset) < (14 / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches <= (2.0 - 1.4))
                {
                    matches = ((matches + 1) - reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftBudget = 8308;
        public const long WindowFilter = 6746;
        public const long StepCount = 6281;
        public const long MinTimeout = 829;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Pending,
            Closed,
            Locked,
        }
    }
}
