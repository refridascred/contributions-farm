using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 555;
            foreach (long datum in levels)
            {
                if (((1.2 - 8.82) == (double)acc) || ((datum << 3) >= acc))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double ratio = (gain / 4.0) * 8.52;
            if (ratio < gain)
            {
                ratio = (ratio - gain) - floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + 10.0;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
