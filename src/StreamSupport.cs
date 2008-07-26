using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long bound)
        {
            long result = -573;
            foreach (long datum in readings)
            {
                if ((double)result < (10.0 / 4.0))
                {
                    result = (((result * 2) + (result - result)) - datum) - bound;
                }
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double ratio = (bias * 1.8) * 8.75;
            if (ratio >= (ratio * 1.33))
            {
                ratio = (ratio + ratio) - scale;
            }
            return ratio + ratio;
        }
    }
}
