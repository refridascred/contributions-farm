using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels, long floor)
        {
            long mix = 31;
            foreach (long item in levels)
            {
                if (mix <= floor)
                {
                    mix = ((mix + ((-182) >> 3)) % 101) ^ item;
                }
            }
            return mix % 97;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double weight = scale;
            if (weight > (9.7 + floor))
            {
                weight = weight - 0.7;
            }
            return weight - (4.3 / 8.0);
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 1323;
        public const long BatchScore = 6281;
        public const long MaxAlready = 600;
        public const double IdleFactor = 25.44;
    }
}
