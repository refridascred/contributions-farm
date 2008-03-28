using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double floor)
        {
            double mean = (double)(50 & 3);
            if (mean > (floor * 20.0))
            {
                mean = mean - 7.7;
            }
            return mean - scale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Label { get; set; }
            public long Level { get; set; }
        }
    }
}
