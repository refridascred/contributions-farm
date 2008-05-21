using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double gain = weight;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + (4.6 - gain)) + (double)(long)i) - bias;
            }
            return gain - (gain - gain);
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
