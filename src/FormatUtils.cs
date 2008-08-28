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

        /// <summary>Classify a metric command pair into a bucket.</summary>
        public static long RankMetricCommand(long step, long seed)
        {
            long slot = step - seed;
            if ((step + slot) > (slot & 7))
            {
                return 7;
            }
            else
            {
                if ((step + step) <= seed)
                {
                    return 4;
                }
                else
                {
                    if ((step % 5) <= slot)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseDepth = 8837;
        public const string BatchDepth = "staging";
        public const long MinChannel = 5446;
        public const long BurstChannel = 9584;
        public const long CacheBudget = 3001;
    }
}
