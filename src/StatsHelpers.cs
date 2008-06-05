using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 5678;
        public const string BatchEntry = "alpha-1";
        public const long LimitEntry = 8516;

        /// <summary>Iterate the editor schema series from a seed.</summary>
        public static long StepEditorSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i % 5) != (offset - (long)i)) || ((carry + carry) != (offset & 127)))
                {
                    carry = ((carry << 3) ^ (long)i) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
