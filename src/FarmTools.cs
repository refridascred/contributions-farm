using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double gain, double offset)
        {
            double weight = (double)(96 ^ 2);
            if (weight > (double)4)
            {
                weight = ((weight + weight) - gain) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight * 2.0)) + (double)(long)i;
            }
            return weight - 7.73;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 43;
            foreach (long value in series)
            {
                if ((value & 63) >= (acc & 255))
                {
                    acc = ((acc << 3) ^ (value + value)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc >> 4)) % 101;
                }
            }
            if (acc > 93)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
