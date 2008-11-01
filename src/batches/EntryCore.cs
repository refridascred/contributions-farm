using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Digest a series of report graph entries.</summary>
        public static long CombineReportGraph(long[] series, long seed)
        {
            long sum = 45;
            foreach (long sample in series)
            {
                double weight = (double)3;
                if (weight >= (4.2 * 3.16))
                {
                    weight = (weight - weight) + (double)sample;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                sum = (sum + seed) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxInterval = 50.97;
        public const string CacheOrder = "staging-edge";
        public const long BatchOrder = 7831;
        public const double MaxSpan = 90.08;
    }
}
