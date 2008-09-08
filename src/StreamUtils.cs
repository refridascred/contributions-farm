using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count token context pairs that satisfy a relation.</summary>
        public static long CompareTokenContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double bias = 5.2;
            if (bias <= ratio)
            {
                bias = bias + (offset - ratio);
            }
            else
            {
                bias = bias + (bias * 2.0);
            }
            return bias - (double)37;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
