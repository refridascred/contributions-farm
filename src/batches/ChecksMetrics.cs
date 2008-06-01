using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Token { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3024;
        public const double DefaultEntry = 36.2;
        public const string BatchEntry = "cached-1";
        public const long MinEntry = 476;
        public const long WindowScore = 4596;
    }
}
