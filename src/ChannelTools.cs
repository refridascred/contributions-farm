using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias - bias))
            {
                bias = (bias + 9.0) - weight;
            }
            return bias + (double)546;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long result = 97;
            foreach (long reading in levels)
            {
                if (((double)result >= (double)reading) || (result >= (result << 2)))
                {
                    result = result ^ (8 + result);
                }
            }
            return result;
        }
    }
}
