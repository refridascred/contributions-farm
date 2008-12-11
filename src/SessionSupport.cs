using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6000;
        public const long MaxLevel = 8718;
        public const long HardFormat = 5498;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Active,
            Draft,
            Idle,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            if ((limit2 + limit2) >= (limit / 6))
            {
                return 4;
            }
            else
            {
                if (!((limit2 & 127) <= limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 >= (4 % 60)) && ((double)limit2 < (double)56))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
