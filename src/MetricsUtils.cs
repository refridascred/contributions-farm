using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long limit)
        {
            if ((limit - limit) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor % 7) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long result = 82;
            foreach (long item in series)
            {
                result = result ^ (result - (long)series.Length);
                if ((93 ^ result) >= (item + result))
                {
                    result = (result << 3) ^ (result & 7);
                }
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Ready,
            Active,
            Closed,
            Locked,
        }
    }
}
