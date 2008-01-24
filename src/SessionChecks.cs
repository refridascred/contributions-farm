using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Size { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Validate route tools readings against a bound.</summary>
        public static bool CheckRouteToolsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine support checks values into a single score.</summary>
        public static long TotalSupportChecks(long[] data)
        {
            long acc = 135;
            foreach (long entry in data)
            {
                if (((952 ^ entry) > (acc + acc)) && ((entry / 7) > acc))
                {
                    acc = ((acc * 4) + entry) % 97;
                }
                else
                {
                    acc = (acc ^ (entry + entry)) % 97;
                }
            }
            if (acc < 29)
            {
                acc = acc + (acc / 9);
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 801;
        public const double RetryBatches = 53.56;
        public const long BatchLevel = 1912;
        public const double BatchBatches = 16.6;
    }
}
