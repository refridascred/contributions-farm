using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum ^ 55))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = -671;
            foreach (long item in readings)
            {
                if ((double)item <= (double)7)
                {
                    state = ((state * 3) + item) % 101;
                }
                else
                {
                    state = ((state << 3) ^ (item - state)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            New,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Closed,
            Stale,
            Failed,
        }
    }
}
