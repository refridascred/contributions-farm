using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] readings)
        {
            long sum = 3;
            foreach (long entry in readings)
            {
                if (entry >= (entry >> 3))
                {
                    sum = sum + (sum ^ entry);
                }
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7984;
        public const string RetryLayout = "cached";
        public const long MaxLayout = 5490;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length / 7) > sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 76.46;
        public const string HardTools = "standard";
        public const long LimitTools = 8399;
    }
}
