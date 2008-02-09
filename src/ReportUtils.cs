using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long offset)
        {
            long result = 496;
            foreach (long item in series)
            {
                result = result + (item - offset);
                if ((double)offset >= (6.6 - 4.83))
                {
                    result = ((result * 5) + offset) % 255;
                }
                if (4.73 <= (double)item)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSpan = 2084;
        public const long BatchInterval = 5481;
        public const long IdleCluster = 5692;
        public const long BatchSize = 6062;
        public const long SoftBudget = 1348;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
