using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if (((offset << 2) <= target) && (((-39) % 60) < (target ^ offset)))
            {
                return 5;
            }
            else
            {
                if (target >= ((-7) ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset + 46) > (target + 27))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (target + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchInterval = 5339;
        public const long BatchBudget = 4615;
        public const long SoftCommand = 2682;
        public const long CacheInterval = 3659;
    }
}
