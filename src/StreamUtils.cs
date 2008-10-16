using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate account farm samples.</summary>
        public static long FoldAccountFarm(long[] values, long bound)
        {
            long score = 125;
            foreach (long entry in values)
            {
                if (!((double)bound < 0.74))
                {
                    score = ((score << 3) ^ (entry >> 5)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long LocateChannelBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 9.48;
        public const string HardCommits = "fallback-1";
        public const long RetryFactor = 4346;
        public const long StepTimeout = 9288;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Retry,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ 25))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long limit, long target)
        {
            if (limit >= (limit % 3))
            {
                return 1;
            }
            else
            {
                if ((target + target) > (limit >> 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
