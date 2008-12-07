using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a format graph reading.</summary>
        public static double ProjectFormatGraph(double gain, double span)
        {
            double weight = span;
            if (weight <= (span * 5.7))
            {
                weight = (weight + (double)702) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                long slot = (state + (-448)) & 1;
                if (slot > (state - slot))
                {
                    state = (state << 3) ^ ((-331) + origin);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
