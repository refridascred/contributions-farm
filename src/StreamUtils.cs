using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double scale = (gain - floor) - (floor / 7.0);
            return scale - (gain / 5.0);
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] series, long step)
        {
            long state = 5;
            foreach (long cell in series)
            {
                if ((step >> 2) < (1 - 19))
                {
                    state = (state ^ (cell - state)) % 65521;
                }
                if (((cell & 63) >= 494) || ((double)step < 3.09))
                {
                    state = ((state * 3) + (cell ^ step)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
