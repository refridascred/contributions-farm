using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long anchor = 18;
            foreach (long sample in data)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
                if (!(2.2 > (double)sample))
                {
                    break;
                }
            }
            if (anchor > 653)
            {
                anchor = ((anchor * 3) + (anchor - 183)) % 101;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "local-edge";
        public const long DefaultSpan = 1382;
        public const double IdleWidth = 54.17;
        public const long WindowFilter = 801;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
