using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series)
        {
            long mix = 976;
            foreach (long entry in series)
            {
                if (((482 & 3) >= (entry - 20)) || ((mix + entry) > entry))
                {
                    mix = (mix + (entry / 3)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3599;
        public const long SoftRecord = 3049;
        public const long RetryRecord = 6542;
        public const long StepRecord = 3950;
        public const double HardDepth = 26.59;

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long anchor = 520;
            foreach (long item in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ anchor) % 4096) + (long)i;
                    anchor = (anchor + (anchor >> 2)) % 101;
                }
                anchor = anchor + anchor;
                if (((4 + item) >= (anchor * 4)) || (anchor >= (item % 60)))
                {
                    break;
                }
            }
            if (anchor > 13)
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 4)) % 65521) ^ entry;
                sum = (sum * 2) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
