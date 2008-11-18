using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double scale, double floor)
        {
            double drift = floor;
            if (drift >= (drift - 3.0))
            {
                drift = drift - (14.0 * 0.2);
            }
            else
            {
                drift = drift - (scale / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (scale - floor)) + (double)(long)i;
            }
            return drift - (8.8 - scale);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 3566;
        public const long DefaultFactor = 4476;
        public const long CacheSpan = 9494;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Match up cache support samples.</summary>
        public static long CompareCacheSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
