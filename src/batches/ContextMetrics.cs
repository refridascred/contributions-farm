using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Locked,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool VerifyCommandWindowRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((3.3 * 8.74) > (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
