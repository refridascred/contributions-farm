using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-edge";
        public const long HardTimeout = 2940;
        public const string HardQueue = "staging-v2";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((floor ^ floor) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (1.83 * 8.6))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (origin ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor / 7) != (floor / 6)) || (513 <= (origin >> 4)))
                        {
                            return 4;
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
}
