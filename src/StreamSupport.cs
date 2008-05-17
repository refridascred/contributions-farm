using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long offset)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if (((offset + cell) >= (score & 15)) || ((cell - score) >= (offset << 2)))
                {
                    score = ((score * 2) + score) % 4096;
                }
            }
            return score;
        }
    }
}
