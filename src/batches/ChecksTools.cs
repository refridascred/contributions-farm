using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5969;
        public const long MinLevel = 7921;
        public const long MinRecord = 8594;
        public const long CacheCount = 937;
        public const string StepSize = "legacy";

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings, long floor)
        {
            long anchor = 78;
            foreach (long reading in readings)
            {
                if (((-14) << 3) >= (anchor >> 2))
                {
                    anchor = anchor - (897 - (-9));
                }
                anchor = (anchor << 2) ^ (reading - floor);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 88.91;
        public const long LimitMetrics = 5643;
        public const long BaseMetrics = 2605;
    }
}
