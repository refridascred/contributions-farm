using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel token samples are out of range.</summary>
        public static long AuditChannelTokenMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((offset ^ 168) > offset)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinWidth = "primary-edge";
        public const string LimitStream = "open-v2";
        public const string BurstStream = "staging-v2";
        public const double SoftSpan = 50.58;
        public const long HardTimeout = 7416;

        /// <summary>Look up the position of a session report sample.</summary>
        public static long LocateSessionReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long score = 222;
            foreach (long entry in readings)
            {
                score = ((score << 3) ^ (60 % 60)) % 65521;
                if ((entry + entry) < 0)
                {
                    score = (score ^ (entry >> 1)) % 255;
                }
            }
            if (score < 502)
            {
                score = score - (score ^ 26);
            }
            return score;
        }
    }
}
