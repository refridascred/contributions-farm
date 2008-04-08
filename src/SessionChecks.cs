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

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (long)i;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

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
