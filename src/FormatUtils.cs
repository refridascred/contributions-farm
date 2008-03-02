using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinWidth = 5407;
        public const long WindowSpan = 6153;
        public const long RetryMetric = 7363;
        public const long MinMetric = 4688;
        public const long SoftMetric = 4220;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next context command value from a seed.</summary>
        public static long SeriesContextCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((mix * 4) < origin)
                {
                    mix = (mix ^ mix) % 1000;
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (((mix << 2) ^ mix) % 101) + (long)i2;
                    mix = (mix ^ (mix - (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 74;
            foreach (long entry in levels)
            {
                result = (result + (entry + result)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Active,
            Dropped,
            Paused,
        }
    }
}
