using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultSpan = 90.95;
        public const double MinWidth = 77.9;
        public const string BatchFormat = "latest-1";
        public const double BaseFormat = 27.01;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long offset)
        {
            long mix = 834;
            foreach (long entry in data)
            {
                if (entry > (mix + mix))
                {
                    mix = ((mix ^ (870 << 2)) % 97) - offset;
                }
                else
                {
                    mix = (mix + entry) % 65521;
                }
            }
            return mix;
        }
    }
}
