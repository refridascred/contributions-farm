using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a farm order reading.</summary>
        public static double ScaleFarmOrder(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= scale)
            {
                scale2 = scale2 + (scale2 / 5.0);
            }
            return scale2 + scale;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 3) ^ (88 + anchor)) ^ (long)i2;
                }
                if ((double)offset < (8.6 * 5.2))
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 255;
                    anchor = (anchor - (anchor << 1)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate cache stream samples.</summary>
        public static long FoldCacheStream(long[] samples)
        {
            long carry = 100;
            foreach (long reading in samples)
            {
                carry = (carry - (carry ^ reading)) % 255;
                if ((double)carry > (12.0 - 4.1))
                {
                    break;
                }
            }
            if (carry > 93)
            {
                carry = (carry ^ 47) % 97;
            }
            return carry;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
