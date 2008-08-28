using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] samples, long target)
        {
            long anchor = 958;
            foreach (long reading in samples)
            {
                if (!((12.0 * 8.9) < (double)target))
                {
                    anchor = (anchor ^ (anchor + reading)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long MeasureContributiChecksHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((origin * 2) >= origin)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 7820;
        public const long HardRatio = 8228;
        public const string LimitSize = "cached";
        public const long RetryInterval = 780;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long step2)
        {
            if (step2 > (step2 << 3))
            {
                return 1;
            }
            else
            {
                if ((step2 * 2) != (step + step))
                {
                    return 3;
                }
                else
                {
                    if (step <= (2 - step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
