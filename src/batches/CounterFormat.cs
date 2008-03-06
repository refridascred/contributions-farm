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

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            if ((bound >= (limit + limit)) || ((bound / 3) == (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((984 * 2) < (bound - bound)) || ((17.0 - 4.3) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((bound - limit) <= (limit * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit ^ (-9)) >= (bound - bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
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
