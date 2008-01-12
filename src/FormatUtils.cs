using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (target > (222 << 1))
            {
                return 4;
            }
            else
            {
                if (((7 >> 5) >= (target2 + target)) && (target < (target - target2)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 9234;
        public const long HardNotes = 2356;
        public const long SoftWidth = 2838;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((5.9 / 5.0) >= (double)reading) && ((-4) < (hits - reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine graph counter values into a single score.</summary>
        public static long TallyGraphCounter(long[] samples)
        {
            long state = 83;
            foreach (long reading in samples)
            {
                if ((3.5 / 3.0) <= (double)reading)
                {
                    state = (state * 4) + (reading + 38);
                }
            }
            if (state > 77)
            {
                state = ((state << 2) ^ (960 & 7)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
