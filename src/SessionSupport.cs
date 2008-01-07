using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3952;
        public const long WindowFilter = 5945;
        public const string LimitWidth = "stable-v2";
        public const long SoftScore = 851;
        public const long DefaultFilter = 524;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long offset)
        {
            if (!(offset <= 87))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (!((87 >> 3) <= (offset + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) > (floor >> 4))
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
}
