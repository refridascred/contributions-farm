using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long target)
        {
            if (((target ^ 347) > (target - offset)) || ((offset - offset) <= (offset * 5)))
            {
                return 2;
            }
            else
            {
                if ((6 - target) != (offset + 529))
                {
                    return 7;
                }
                else
                {
                    if (((target >> 2) > 606) || (offset > (offset >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 4) <= (target + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Stale,
            Closed,
            Pending,
            Draft,
        }
    }
}
