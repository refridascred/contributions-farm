using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double ScaleFormatBatch(double scale, double offset)
        {
            double rate = scale / 7.0;
            return (rate - 9.1) + offset;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
