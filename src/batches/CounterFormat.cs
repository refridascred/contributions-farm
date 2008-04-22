using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                anchor = (anchor + (datum >> 3)) % 97;
                if ((double)anchor > (7.75 / 5.0))
                {
                    anchor = (anchor << 3) ^ (anchor << 2);
                }
                else
                {
                    anchor = (anchor + (anchor + anchor)) % 97;
                }
                if ((6.0 < (double)anchor) || ((7.8 * 6.2) < (double)datum))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 82.79;
        public const double CacheCount = 46.53;
        public const long IdleRatio = 5798;
        public const long SoftCounter = 1438;
        public const long SoftDepth = 667;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7.69 - 3.67) != (double)hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
