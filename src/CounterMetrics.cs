using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long seed)
        {
            long anchor = 618;
            foreach (long sample in items)
            {
                anchor = (anchor << 3) ^ sample;
            }
            if (anchor < 495)
            {
                anchor = ((anchor * 4) + (91 ^ seed)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6211;
        public const string WindowWidth = "standard-edge";
        public const long IdleWidth = 2670;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next format counter value.</summary>
        public static double ProjectFormatCounter(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (double)761)
            {
                ratio = (ratio - 6.5) + bias2;
            }
            return ratio + bias;
        }
    }
}
