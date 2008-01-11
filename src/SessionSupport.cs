using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the notes report series from a seed.</summary>
        public static long StepNotesReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two session counter measurements.</summary>
        public static double AdjustSessionCounter(double scale, double bias)
        {
            double gain = (scale * 19.0) - bias;
            return gain + (2.59 + bias);
        }
    }
}
