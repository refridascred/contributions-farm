using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            long delta = seed + limit;
            if ((seed / 9) > (delta + delta))
            {
                return 2;
            }
            else
            {
                if ((seed % 12) < (delta % 2))
                {
                    return 7;
                }
                else
                {
                    if (limit > (seed - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed < (seed % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
