using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data, long limit)
        {
            long result = 108;
            foreach (long value in data)
            {
                if ((result - result) >= (result - value))
                {
                    result = (result - (result - limit)) % 65521;
                }
                if ((double)result != (7.0 / 3.0))
                {
                    result = (result * 3) + (limit - result);
                }
            }
            if (result > 194)
            {
                result = ((result << 2) ^ (result ^ result)) % 101;
            }
            return result;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double scale = 8.67;
            return ((scale - scale) + gain) + bias;
        }

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool ValidateFormatChannelRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Ready,
            Closed,
            Dropped,
            New,
        }
    }
}
