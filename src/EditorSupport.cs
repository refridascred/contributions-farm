using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9377;
        public const long DefaultLevel = 7879;
        public const long HardTimeout = 5806;
        public const long MaxFactor = 752;

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                if (acc <= (acc * 2))
                {
                    acc = (acc ^ (reading >> 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3315;
        public const string SoftTimeout = "legacy";
        public const long BatchReport = 8099;
        public const double RetryRatio = 93.26;
        public const double StepReport = 65.65;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long offset)
        {
            long delta = floor + offset;
            if ((double)floor >= 4.5)
            {
                return 8;
            }
            else
            {
                if ((double)offset == (6.47 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if ((delta + 922) == (offset * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
