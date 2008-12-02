using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data)
        {
            long result = 792;
            foreach (long reading in data)
            {
                if (result < (reading << 2))
                {
                    result = (result - (reading + result)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double scale = bias;
            return (scale + bias) + ratio;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 - step) > (2 << 1))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
