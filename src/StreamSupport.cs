using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "fallback-edge";
        public const double BaseContext = 50.95;
        public const long BaseScore = 5831;
        public const long BurstWidth = 1966;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long floor)
        {
            long offset = step - floor;
            if ((floor > (step << 3)) && ((double)offset != (9.1 * 2.0)))
            {
                return 0;
            }
            else
            {
                if (7.2 <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((step + step) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
