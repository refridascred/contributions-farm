using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 364;
        public const long BaseBuffer = 2467;
        public const string IdleBuffer = "legacy-v2";
        public const long SoftBuffer = 9794;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long target)
        {
            long next = origin - target;
            if ((double)target > (2.1 - 6.0))
            {
                return 4;
            }
            else
            {
                if ((double)target != (4.9 - 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((target - next) == (next + next)) && ((next - origin) <= 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
