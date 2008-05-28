using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long MeasureFormatSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches > 9.0)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route schema samples.</summary>
        public static long WeighRouteSchema(long[] items, long seed)
        {
            long mix = 897;
            foreach (long sample in items)
            {
                mix = (((mix << 2) ^ (54 >> 3)) ^ sample) + seed;
            }
            return mix % 97;
        }
    }
}
