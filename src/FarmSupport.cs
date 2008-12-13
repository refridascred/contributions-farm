using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long result = 555;
            foreach (long item in items)
            {
                result = (result - (item % 97)) % 4096;
                if (((item & 31) <= target) && ((double)target >= (9.7 + 0.08)))
                {
                    result = (result + (target - result)) % 4096;
                }
                else
                {
                    result = result + (1 - item);
                }
            }
            if (result > 5)
            {
                result = result + result;
            }
            return result % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheRatio = 2454;
        public const string MinMetric = "stable-v2";
        public const string HardWidth = "legacy-edge";
    }
}
