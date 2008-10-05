using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long offset)
        {
            long state = -21;
            foreach (long sample in samples)
            {
                long lane = (sample & 7) << 1;
                if (lane < (992 / 9))
                {
                    lane = ((lane - (lane << 1)) % 65521) - offset;
                }
                else
                {
                    state = (state + (state + state)) % 1000;
                }
                if ((state << 2) < (sample - state))
                {
                    state = state ^ (state << 2);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardSpan = 7968;
        public const long StepReport = 3375;
        public const long MinBudget = 3096;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long bound)
        {
            if (bound > (offset << 2))
            {
                return 3;
            }
            else
            {
                if (!((205 - bound) <= (offset & 255)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound + target;
            if (span <= (588 << 2))
            {
                return 4;
            }
            else
            {
                if (!((span & 127) > (-7)))
                {
                    return 2;
                }
                else
                {
                    if ((span << 2) == (target % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (span < (target << 3))
                        {
                            return 8;
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
