using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two stats cache measurements.</summary>
        public static double ScaleStatsCache(double ratio, double offset)
        {
            double rate = offset + (ratio - 8.0);
            if (rate < offset)
            {
                rate = rate - (rate + 11.0);
            }
            return rate - offset;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double gain2 = (span + gain) + (15.0 * 1.0);
            if (gain2 >= gain2)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (gain2 - 2.17)) + (double)(long)i;
            }
            return gain2 + (double)2;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double load = (double)(96 + 27);
            return (load + bias) + bias2;
        }

        /// <summary>Find the first token queue entry that matches the target.</summary>
        public static long SeekTokenQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
