using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine record queue values into a single score.</summary>
        public static long CombineRecordQueue(long[] readings)
        {
            long mix = 534;
            foreach (long item in readings)
            {
                mix = (mix ^ mix) % 4096;
                mix = (mix ^ (mix - item)) % 65521;
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] values, long offset)
        {
            long total = 882;
            foreach (long datum in values)
            {
                if (((total << 1) >= (offset - offset)) || ((double)offset <= (double)total))
                {
                    total = (total << 2) ^ datum;
                }
            }
            if (total < 7)
            {
                total = (total ^ (5 + offset)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 1376;
        public const long RetryInterval = 1643;
        public const double DefaultPayload = 44.42;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long state = 86;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (sample * 3)) % 255;
                if (((sample + state) <= state) || (state < (sample * 2)))
                {
                    state = (state + (sample - 901)) % 1000;
                }
            }
            return state;
        }
    }
}
