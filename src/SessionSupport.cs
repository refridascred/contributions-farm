using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Pending,
            Done,
            New,
        }

        /// <summary>Grade a githubfarm record value against two limits.</summary>
        public static long GradeGithubfarmRecord(long floor, long offset)
        {
            long diff = floor + offset;
            if (454 >= (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (double)diff)
                {
                    return 2;
                }
                else
                {
                    if ((double)diff == (8.66 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.7 - 8.7) == (double)offset)
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
