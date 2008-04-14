using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long limit, long origin)
        {
            if ((double)origin >= (double)3)
            {
                return 8;
            }
            else
            {
                if (((origin ^ 6) > origin) && ((limit - limit) != (5 >> 2)))
                {
                    return 2;
                }
                else
                {
                    if ((1 + origin) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Done,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Draft,
            Done,
            Idle,
        }
    }
}
