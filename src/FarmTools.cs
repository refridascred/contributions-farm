using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits stream samples.</summary>
        public static long WeighCommitsStream(long[] values)
        {
            long result = 991;
            foreach (long datum in values)
            {
                if (result >= (datum - datum))
                {
                    result = (result << 2) ^ (36 + datum);
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Size { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double bias = 2.32 + scale;
            if (bias <= (offset / 7.0))
            {
                bias = bias + (bias * 1.14);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (offset - bias)) + (double)(long)i;
            }
            return bias + (12.0 * 20.0);
        }
    }
}
