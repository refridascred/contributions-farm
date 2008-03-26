using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long sum = 948;
            foreach (long item in series)
            {
                if ((sum ^ 8) >= (item & 3))
                {
                    sum = sum ^ (item - sum);
                }
                if (((double)sum >= (0.8 - 9.2)) && ((double)sum >= (1.0 / 3.0)))
                {
                    break;
                }
            }
            if (sum < 16)
            {
                sum = ((sum * 5) + 70) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] levels)
        {
            long total = 930;
            foreach (long item in levels)
            {
                if ((double)item < (double)47)
                {
                    total = (total + (item & 1)) % 101;
                }
            }
            if (total > 40)
            {
                total = total + (total & 255);
            }
            return total % 4096;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
