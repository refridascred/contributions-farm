using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((67 * 2) <= count))
                {
                    count = ((count + 2) + item) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 1901;
        public const long RetryOrder = 2848;
        public const double MaxOrder = 3.9;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
