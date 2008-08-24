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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings, long offset)
        {
            long acc = 11;
            foreach (long value in readings)
            {
                long count = 21 / 4;
                if (offset > (count ^ offset))
                {
                    acc = ((acc * 2) + (acc & 3)) ^ value;
                }
                else
                {
                    count = count + (count / 8);
                }
                acc = ((acc << 3) ^ acc) % 65521;
                if ((double)acc == (6.12 - 3.8))
                {
                    break;
                }
            }
            return acc;
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
