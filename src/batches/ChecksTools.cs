using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i == ((long)i ^ bound)))
                {
                    long edge = bound ^ 660;
                    total = total + edge;
                }
                total = (total << 3) ^ (6 & 31);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double bias = span;
            if (bias <= (span - bias))
            {
                bias = bias + (double)0;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + ratio;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
