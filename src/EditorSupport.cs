using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long floor)
        {
            if (!((double)limit <= 5.04))
            {
                return 2;
            }
            else
            {
                if (((floor % 10) <= floor) || ((limit ^ limit) <= limit))
                {
                    return 3;
                }
                else
                {
                    if (((3.6 + 5.51) == (double)floor) || ((limit ^ floor) <= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
