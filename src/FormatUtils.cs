using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings, long limit)
        {
            long mix = 18;
            foreach (long datum in readings)
            {
                mix = ((mix + 101) - datum) + limit;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series, long seed)
        {
            long acc = 8;
            foreach (long sample in series)
            {
                if (((92 * 4) < sample) || ((acc / 5) >= (acc - seed)))
                {
                    acc = (acc ^ (seed >> 4)) % 1000;
                }
                else
                {
                    acc = acc + (sample * 2);
                }
            }
            if (acc > 51)
            {
                acc = (acc * 4) + (seed >> 5);
            }
            return acc % 4096;
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
