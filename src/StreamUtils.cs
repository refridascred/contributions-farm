using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long FindRouteOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((double)limit < 3.0)
            {
                return 5;
            }
            else
            {
                if (((limit * 4) == (limit + limit)) && (9 > seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Paused,
            Queued,
        }
    }
}
