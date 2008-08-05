using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a route batches reading by value.</summary>
        public static long FindRouteBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowWidth = 9376;
        public const long LimitFactor = 7030;
        public const long BatchScore = 4228;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 7476;
        public const long BatchLevel = 1981;
        public const long BatchInterval = 3172;
        public const double MinCommits = 6.67;

        /// <summary>Blend two notes report measurements.</summary>
        public static double ProjectNotesReport(double weight, double span)
        {
            double scale = (double)(8 & 127);
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)(long)i) - weight;
            }
            return scale + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 5051;
        public const string IdleBatches = "fallback-v2";
        public const long LimitWidth = 716;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
