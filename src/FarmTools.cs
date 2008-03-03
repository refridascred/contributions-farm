using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long limit)
        {
            long anchor = 14;
            foreach (long sample in levels)
            {
                if ((double)anchor <= (7.0 - 19.0))
                {
                    anchor = (((anchor * 3) + anchor) % 65521) ^ sample;
                }
            }
            if (anchor < 823)
            {
                anchor = (anchor + (limit ^ anchor)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up payload notes samples.</summary>
        public static long PairPayloadNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
