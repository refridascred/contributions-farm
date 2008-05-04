using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                if ((mark <= (mark >> 3)) || ((double)mark > (1.06 / 8.0)))
                {
                    mark = mark ^ (value - mark);
                }
            }
            return mark;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleFactor = 87.3;
        public const double MinRatio = 0.76;
        public const string MinTimeout = "stable-edge";
    }
}
