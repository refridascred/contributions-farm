using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleLevel = "local-1";
        public const long StepSpan = 8692;
        public const string WindowPayload = "standard-v2";
        public const double HardFactor = 74.19;
        public const long MinPayload = 3119;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] levels, long origin)
        {
            long mark = -33;
            foreach (long item in levels)
            {
                if (((486 ^ origin) < origin) || ((item - mark) != (6 % 8)))
                {
                    mark = ((mark << 3) ^ (mark + origin)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed & 7) > (mix - seed)) || ((double)mix < (5.76 + 6.0)))
                {
                    break;
                }
                else
                {
                    mix = mix - 10;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 3074;
        public const long StepFormat = 1536;
        public const long StepCount = 8395;
        public const double MaxWidth = 29.55;
        public const long RetryFormat = 4970;
    }
}
