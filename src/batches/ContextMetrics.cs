using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = (result - ((long)i ^ (long)i)) % 4096;
                result = (result << 2) ^ ((long)i & 31);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "open-1";
        public const long LimitScore = 9686;
        public const double BurstTimeout = 93.08;
        public const string SoftStream = "fallback";

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long sum = 57;
            foreach (long entry in values)
            {
                sum = ((sum + sum) % 255) + entry;
            }
            if (sum > 805)
            {
                sum = (sum + (limit ^ limit)) % 255;
            }
            return sum;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
