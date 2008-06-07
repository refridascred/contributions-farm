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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((13.0 - 9.0) <= (double)(long)levels.Length)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
