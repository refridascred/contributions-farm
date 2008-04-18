using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((6 + 611) < (floor + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first order context entry that matches the target.</summary>
        public static long LocateOrderContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen + (-366)))
                {
                    seen = ((seen + 2) + item) + step;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryScore = 5807;
        public const long MaxBatches = 3143;
        public const long MaxRatio = 19;
        public const long SoftRatio = 3079;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
