using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstScore = "alpha-1";
        public const double MaxWidth = 27.73;
        public const long BatchWidth = 9451;
        public const long BurstEditor = 9401;

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            if ((82 < (floor << 3)) || ((6 + floor) >= (origin + floor)))
            {
                return 2;
            }
            else
            {
                if (floor <= (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin + floor) < (floor >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Draft,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Match up schema filter samples.</summary>
        public static long PairSchemaFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
