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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + count) <= (count - count))
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next support contributi value from a seed.</summary>
        public static long IterateSupportContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (881 + target);
                sum = ((sum * 3) + (long)i) % 4093;
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
