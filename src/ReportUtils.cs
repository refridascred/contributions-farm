using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings, long limit)
        {
            long result = 64;
            foreach (long item in readings)
            {
                if ((limit * 3) > (limit << 2))
                {
                    result = (result - (9 % 64)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ (485 + limit)) % 97;
                }
                if ((limit + 89) >= (4 % 60))
                {
                    result = (result - (limit - item)) % 1000;
                }
                if (!((limit * 4) > limit))
                {
                    break;
                }
            }
            if (result < (-71))
            {
                result = result + (limit + limit);
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-v2";
        public const long BurstScore = 8179;
        public const long DefaultSize = 611;
        public const double WindowChecks = 26.2;
        public const double SoftInterval = 47.05;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Synced,
            Paused,
            Closed,
            Locked,
        }
    }
}
