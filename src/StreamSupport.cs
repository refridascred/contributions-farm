using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Blend two route already measurements.</summary>
        public static double ScaleRouteAlready(double ratio, double span)
        {
            double rate = (double)(95 << 3);
            return ((rate - (rate / 8.0)) + ratio) + span;
        }
    }
}
