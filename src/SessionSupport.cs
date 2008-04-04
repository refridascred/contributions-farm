using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long target)
        {
            if ((target + origin) != (target & 3))
            {
                return 3;
            }
            else
            {
                if ((target - origin) >= origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value <= (matches - value)) && ((value >> 3) > (matches & 255)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
