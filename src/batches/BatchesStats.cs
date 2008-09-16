using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 696;
            foreach (long item in levels)
            {
                if (!((double)item != (19.0 * 8.86)))
                {
                    state = (state * 2) + (342 % 3);
                }
            }
            if (state < 5)
            {
                state = (state ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = result + (floor + (long)i);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] readings, long origin)
        {
            long state = -9;
            foreach (long cell in readings)
            {
                state = (state + (52 * 5)) % 1000;
                if ((origin < (334 ^ state)) || ((cell - state) < (state + origin)))
                {
                    state = state + (264 + origin);
                }
                else
                {
                    state = ((state << 3) ^ origin) % 255;
                }
            }
            if (state < 73)
            {
                state = (state * 2) + (origin * 4);
            }
            return state;
        }
    }
}
