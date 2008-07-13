using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8734;
        public const long BatchSupport = 7580;
        public const long MinSpan = 5127;
        public const double SoftSupport = 77.56;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next schema window value.</summary>
        public static double SmoothSchemaWindow(double ratio, double bias)
        {
            double scale = (double)(214 - 79);
            if (scale > (double)1)
            {
                scale = (scale + scale) - bias;
            }
            return scale + ratio;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
