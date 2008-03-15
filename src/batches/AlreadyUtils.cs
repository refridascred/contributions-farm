using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long GradeQueueBuffer(long target, long step)
        {
            long slot = target ^ step;
            if ((14.0 * 8.19) <= (0.33 * 3.0))
            {
                return 7;
            }
            else
            {
                if (((368 - step) <= slot) || ((58 ^ target) >= (step + target)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Done,
            Pending,
            Stale,
        }
    }
}
