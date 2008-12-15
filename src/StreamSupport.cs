using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if ((double)bound > 6.7)
            {
                return 3;
            }
            else
            {
                if ((seed - 37) < (bound / 6))
                {
                    return 8;
                }
                else
                {
                    if (!((seed + bound) < bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((13.0 - 0.7) > (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Failed,
            Done,
            Ready,
        }
    }
}
