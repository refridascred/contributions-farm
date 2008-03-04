using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long anchor = -64;
            foreach (long datum in readings)
            {
                if (!(anchor > (datum - datum)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                if (!((datum << 2) >= datum))
                {
                    anchor = anchor + (datum - 0);
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 49.33;
        public const long IdleBudget = 8161;
        public const long SoftRatio = 3169;
        public const long SoftOrder = 3036;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum + 23) >= (long)levels.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
