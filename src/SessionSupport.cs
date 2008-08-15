using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank token support input into a small class.</summary>
        public static long ClassifyTokenSupport(long step, long limit)
        {
            long lane = step + limit;
            if ((double)step <= (9.0 * 0.8))
            {
                return 7;
            }
            else
            {
                if ((step + 9) > lane)
                {
                    return 4;
                }
                else
                {
                    if ((double)step > (4.0 * 3.2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
