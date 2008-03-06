using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (offset * 8.19))
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 + (2.3 - offset);
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long target, long origin)
        {
            if (((origin >> 4) > (origin >> 2)) || (origin >= (origin ^ 9)))
            {
                return 5;
            }
            else
            {
                if (((target & 255) != (542 >> 1)) && ((target + 12) != (24 ^ origin)))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ target) >= (origin << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
