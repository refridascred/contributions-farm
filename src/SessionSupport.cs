using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Active,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleWidth = "staging-edge";
        public const double WindowFilter = 22.9;
        public const long IdleFilter = 5000;
        public const long StepDepth = 7480;
        public const long HardFilter = 1877;

        /// <summary>Rank already batch input into a small class.</summary>
        public static long GradeAlreadyBatch(long offset, long target)
        {
            if (target <= (target + 780))
            {
                return 8;
            }
            else
            {
                if (5 <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 5) > (566 + 99))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
