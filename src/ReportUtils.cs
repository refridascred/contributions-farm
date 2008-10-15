using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Ready,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Accumulate filter profile samples.</summary>
        public static long DigestFilterProfile(long[] samples)
        {
            long mark = 882;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 255;
                if ((mark & 127) >= (value - 90))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the session editor series from a seed.</summary>
        public static long RollSessionEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state ^ (target + target);
                if (target < state)
                {
                    continue;
                }
                else
                {
                    state = (state - (target ^ 90)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
