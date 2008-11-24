using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - (target ^ target)) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix * 3) + ((long)i2 - (long)i2);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            New,
            Locked,
            Done,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Accumulate commits payload samples.</summary>
        public static long TallyCommitsPayload(long[] series, long origin)
        {
            long state = 9;
            foreach (long value in series)
            {
                if (((double)origin > (1.1 - 3.2)) && ((573 - value) != (value ^ origin)))
                {
                    state = state ^ state;
                }
            }
            return state % 4096;
        }
    }
}
