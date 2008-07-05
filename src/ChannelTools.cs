using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series)
        {
            long sum = 45;
            foreach (long datum in series)
            {
                if ((9 + sum) <= sum)
                {
                    sum = sum - (1 - datum);
                }
            }
            return sum;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double weight = gain;
            if (weight < weight)
            {
                weight = weight + (offset - weight);
            }
            else
            {
                weight = weight + gain;
            }
            return weight - weight;
        }
    }
}
