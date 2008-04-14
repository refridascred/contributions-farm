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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            long lane = target ^ origin;
            if (!((double)origin != (16.0 + 6.0)))
            {
                return 5;
            }
            else
            {
                if ((lane % 8) <= (origin + lane))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
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
