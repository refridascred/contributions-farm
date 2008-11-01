using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally - limit) <= (cell << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Pending,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long result = 390;
            foreach (long reading in levels)
            {
                if (((reading ^ seed) < reading) || (18 >= (seed << 3)))
                {
                    result = ((result << 2) ^ (result * 3)) % 255;
                }
                if ((result & 31) < seed)
                {
                    result = ((result * 5) + (reading * 2)) % 4096;
                }
            }
            if (result > 71)
            {
                result = (result * 4) + (result % 100);
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 81.72;
        public const string StepBatches = "strict-v2";
        public const long LimitBatches = 9075;
    }
}
