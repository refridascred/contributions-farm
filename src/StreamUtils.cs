using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count batches cluster pairs that satisfy a relation.</summary>
        public static long CompareBatchesClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (origin <= (bound + origin))
            {
                return 8;
            }
            else
            {
                if (((origin * 4) <= (diff - 3)) || ((631 + (-805)) >= (diff << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((7.3 + 13.0) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff * 4) != (diff + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long state = 660;
            foreach (long sample in items)
            {
                state = (state << 2) ^ sample;
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitRatio = 29.22;
        public const long MaxBatch = 6071;
        public const double StepBatch = 43.13;
        public const double HardBatch = 89.57;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            New,
            Retry,
            Synced,
            Idle,
        }
    }
}
