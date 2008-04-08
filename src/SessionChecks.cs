using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Token { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of layout format entries.</summary>
        public static long TotalLayoutFormat(long[] readings, long offset)
        {
            long carry = 914;
            foreach (long sample in readings)
            {
                if (!((sample + 941) != (offset * 2)))
                {
                    carry = (carry ^ sample) % 97;
                }
                if (((carry << 2) < 712) || (sample > (0 - (long)readings.Length)))
                {
                    carry = (carry + (carry & 1)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 84.48;
        public const string MinTimeout = "strict-v2";
        public const long HardSpan = 1665;

        /// <summary>Look up the position of a graph stats sample.</summary>
        public static long LocateGraphStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
