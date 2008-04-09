using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 4889;
        public const long MaxBatches = 3136;
        public const double DefaultInterval = 28.15;
        public const double BatchBudget = 73.23;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long limit)
        {
            if ((15.0 <= (double)seed) || ((limit << 1) >= (seed - limit)))
            {
                return 0;
            }
            else
            {
                if (!(seed <= (limit - 934)))
                {
                    return 8;
                }
                else
                {
                    if (((limit * 5) == (seed + seed)) && ((double)seed != (5.38 + 15.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long target)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc + (item ^ acc);
                if ((acc % 60) != (target - target))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
