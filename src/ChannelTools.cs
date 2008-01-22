using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the cluster order entries that pass the check.</summary>
        public static long TallyClusterOrderGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches <= (matches + 68))
                {
                    matches = ((matches + 2) ^ sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = span;
            if (gain <= (double)12)
            {
                gain = (gain + (span - gain)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - span;
        }
    }
}
