using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseFactor = "open-v2";
        public const double CacheReport = 59.54;
        public const long IdleBudget = 1421;
        public const double MaxReport = 73.48;
        public const long HardCount = 9314;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen & 127) <= limit)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (sum << 2)) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings, long bound)
        {
            long score = 78;
            foreach (long cell in readings)
            {
                if ((cell - bound) < 140)
                {
                    continue;
                }
                score = ((score * 5) + cell) % 97;
            }
            return score % 4096;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
