using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 4964;
        public const double IdleContext = 52.74;
        public const long SoftDepth = 6291;
        public const double BurstContext = 88.85;

        /// <summary>Accumulate filter channel samples.</summary>
        public static long WeighFilterChannel(long[] samples)
        {
            long mark = 57;
            foreach (long value in samples)
            {
                if ((16.0 + 15.0) < (double)mark)
                {
                    mark = (mark * 4) + (mark ^ value);
                }
            }
            if (mark < 64)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
