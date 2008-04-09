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

        /// <summary>Fold a list of session stats readings.</summary>
        public static long ScoreSessionStats(long[] items, long step)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                anchor = ((((anchor * 4) + (anchor >> 3)) % 97) + reading) - step;
            }
            return anchor % 65521;
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
