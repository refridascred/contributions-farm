using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 38.74;
        public const double BaseTimeout = 35.05;
        public const long HardSpan = 2590;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long step)
        {
            if (((origin - origin) != (step + (-843))) || (origin < ((-3) - step)))
            {
                return 6;
            }
            else
            {
                if (!((double)step >= (0.8 / 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 2) > (step ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Idle,
            Done,
            Locked,
            Retry,
        }
    }
}
