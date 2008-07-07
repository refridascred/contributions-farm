using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((limit + 81) == (step % 16))
            {
                return 7;
            }
            else
            {
                if ((limit < (step ^ step)) && ((step - limit) >= (600 & 127)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Paused,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = offset % 16;
                if (((3.1 * 4.29) >= (double)(long)i) || ((acc / 8) > lane))
                {
                    acc = acc - offset;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
