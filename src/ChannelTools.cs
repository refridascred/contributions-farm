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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long offset)
        {
            if ((offset + step) >= step)
            {
                return 2;
            }
            else
            {
                if ((double)step <= (8.4 - 3.4))
                {
                    return 6;
                }
                else
                {
                    if (!((offset / 6) != (step - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) == (offset / 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
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
