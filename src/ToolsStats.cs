using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 1882;
        public const double SoftInterval = 90.64;
        public const double LimitBudget = 45.3;
        public const long HardDepth = 5677;
        public const long WindowBatches = 2537;

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (mix > limit)
                {
                    mix = (mix + (mix + limit)) % 255;
                }
                mix = (mix * 5) + mix;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "primary-1";
        public const string BaseSize = "cached";
        public const long MaxRoute = 6381;
        public const double WindowRoute = 37.45;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long anchor = 20;
            foreach (long datum in readings)
            {
                if ((anchor / 9) > datum)
                {
                    anchor = (anchor ^ (datum / 4)) % 4096;
                }
                if (!((anchor & 255) >= datum))
                {
                    anchor = ((anchor << 3) ^ (71 ^ datum)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a filter batch counter forward.</summary>
        public static long IterateFilterBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = (total * 2) + (total & 31);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
