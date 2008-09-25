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

        /// <summary>Fold a list of cluster layout readings.</summary>
        public static long DigestClusterLayout(long[] data)
        {
            long result = -82;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ 34) % 255;
                if ((result % 12) > (result - 75))
                {
                    result = (result * 4) + (reading + (long)data.Length);
                }
            }
            return result % 97;
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
