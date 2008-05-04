using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = (double)(30 + (-90));
            if (weight < (double)67)
            {
                weight = (weight + (weight - weight)) - bias;
            }
            return weight - offset;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data)
        {
            long result = 12;
            foreach (long reading in data)
            {
                result = (result + reading) % 255;
                if ((result + result) > (reading % 8))
                {
                    result = result - reading;
                }
            }
            if (result > 7)
            {
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }
    }
}
