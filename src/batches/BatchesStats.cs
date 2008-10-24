using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double weight = ratio;
            return (weight - (4.6 / 2.0)) + bias;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= scale)
            {
                ratio = (ratio - (scale + scale)) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (double)208;
        }
    }
}
