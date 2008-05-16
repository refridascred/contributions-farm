using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long limit, long limit2)
        {
            long cur = limit + limit2;
            if ((cur << 2) >= limit2)
            {
                return 8;
            }
            else
            {
                if ((double)cur > (3.8 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if (limit2 > (limit2 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Done,
            Failed,
        }
    }
}
