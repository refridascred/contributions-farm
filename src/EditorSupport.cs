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

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Retry,
            New,
            Synced,
        }

        /// <summary>Fold a list of tools order readings.</summary>
        public static long WeighToolsOrder(long[] readings, long seed)
        {
            long result = 642;
            foreach (long item in readings)
            {
                if (((result * 3) > 415) || (((-669) + item) != (result >> 3)))
                {
                    result = result + (seed - item);
                }
                else
                {
                    result = (result - (item & 1)) % 65521;
                }
                if (((result ^ seed) != (result % 3)) || ((seed - seed) <= (seed / 8)))
                {
                    result = (result ^ seed) % 97;
                    result = result + (result * 2);
                    break;
                }
                else
                {
                    result = result ^ (item * 4);
                }
                if (!((item - item) > (seed + seed)))
                {
                    result = ((result * 2) + (item + seed)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ item) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
