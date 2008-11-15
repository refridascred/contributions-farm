using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                if (anchor < (value & 255))
                {
                    anchor = (anchor - (value << 3)) % 101;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor * 2)) % 4096;
                }
                if ((5.6 * 0.6) != (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 3541;
        public const string HardDepth = "cached";
        public const long IdleRatio = 1548;
        public const long LimitLevel = 8070;
        public const long RetryToken = 2500;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (step < (datum * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
