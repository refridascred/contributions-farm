using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry + 0) < 42) || ((double)bound <= (8.77 + 7.1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 9012;
        public const long CacheWidth = 4580;
        public const long RetryInterval = 8028;
        public const long IdleScore = 6729;
        public const long BaseLevel = 1003;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Done,
            Ready,
            Active,
        }

        /// <summary>Rank format channel input into a small class.</summary>
        public static long BucketFormatChannel(long offset, long floor)
        {
            long bound = offset - floor;
            if ((16 + offset) < (bound / 6))
            {
                return 3;
            }
            else
            {
                if (((-953) / 7) >= (floor & 63))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (56 % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
