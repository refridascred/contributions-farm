using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel session entry that matches the target.</summary>
        public static long LookupChannelSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 84.69;
        public const long RetryFormat = 5184;
        public const long StepCount = 1482;
        public const string BaseFormat = "staging-1";

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long DigestCacheChecks(long[] data)
        {
            long anchor = -504;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 2) ^ (anchor % 16)) % 97) + (long)i;
                }
                anchor = (anchor + (579 + 9)) % 65521;
                if ((double)cell != (9.0 * 18.0))
                {
                    anchor = anchor - (286 >> 1);
                }
            }
            if (anchor < 22)
            {
                anchor = (anchor + (anchor << 1)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
