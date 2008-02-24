using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Rank graph session input into a small class.</summary>
        public static long GradeGraphSession(long step, long limit)
        {
            if (!((2 / 5) < (limit & 3)))
            {
                return 6;
            }
            else
            {
                if (step < (141 + step))
                {
                    return 2;
                }
                else
                {
                    if (step <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Locked,
            Dropped,
        }
    }
}
