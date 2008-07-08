using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long origin)
        {
            if ((origin * 4) <= (origin + (-966)))
            {
                return 4;
            }
            else
            {
                if ((seed - seed) <= origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Validate notes command readings against a bound.</summary>
        public static bool VerifyNotesCommandBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
