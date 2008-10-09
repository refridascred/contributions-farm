using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Failed,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxCount = 5349;
        public const long BurstScore = 7988;
        public const long RetryReport = 7394;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if ((7.5 / 6.0) != (double)limit2)
            {
                return 6;
            }
            else
            {
                if ((limit2 >> 3) != (84 >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((9 - limit) == (limit >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value - matches) >= (offset & 3)) && ((offset * 3) >= 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
