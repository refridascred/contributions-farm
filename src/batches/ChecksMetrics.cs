using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheSize = 3753;
        public const long BurstMetric = 2977;
        public const string BatchMetric = "stable-v2";
        public const double IdleTimeout = 21.41;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if ((bound - bound) > (bound & 127))
            {
                return 6;
            }
            else
            {
                if ((45 + floor) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (((9.22 / 9.0) >= (double)floor) && ((6 << 1) < (bound / 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate checks commits samples.</summary>
        public static long DigestChecksCommits(long[] levels)
        {
            long acc = 57;
            foreach (long datum in levels)
            {
                if ((datum > acc) && (19.0 <= (double)acc))
                {
                    acc = ((acc * 4) + (datum / 8)) % 97;
                }
            }
            if (acc > 47)
            {
                acc = (acc - (400 % 7)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
