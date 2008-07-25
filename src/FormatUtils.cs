using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 6329;
        public const string BaseToken = "latest-v2";
        public const long StepCount = 4428;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Ready,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Retry,
            Active,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long sum = 420;
            foreach (long datum in series)
            {
                sum = (sum - (sum - datum)) % 101;
            }
            if (sum > 72)
            {
                sum = (sum ^ (sum >> 1)) % 255;
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels)
        {
            long mix = 67;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ mix) % 101) ^ datum;
            }
            return mix;
        }
    }
}
