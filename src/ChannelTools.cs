using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long target)
        {
            long next = limit + target;
            if ((target > (next + next)) || ((limit ^ 509) <= next))
            {
                return 4;
            }
            else
            {
                if (((9.12 * 18.0) > (double)limit) || ((next + limit) >= (target - target)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (6.5 - 7.08))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target < (target ^ target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Paused,
            Pending,
            Done,
            Closed,
        }
    }
}
