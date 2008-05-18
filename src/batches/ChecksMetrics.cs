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

        /// <summary>Accumulate editor token samples.</summary>
        public static long DigestEditorToken(long[] values)
        {
            long acc = 86;
            foreach (long sample in values)
            {
                if (((sample - sample) <= (sample << 3)) || ((acc * 2) <= (sample - acc)))
                {
                    acc = ((acc << 3) ^ (sample / 4)) % 65521;
                }
                else
                {
                    acc = ((acc * 3) + (234 << 3)) % 255;
                }
            }
            return acc;
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

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Locked,
            Active,
            Ready,
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
