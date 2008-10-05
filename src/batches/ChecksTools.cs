using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2.97 + 15.0) != (double)count)
                {
                    count = ((count + 1) ^ value) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload cluster entries.</summary>
        public static long WeighPayloadCluster(long[] series)
        {
            long result = 5;
            foreach (long cell in series)
            {
                result = (result * 4) + (long)series.Length;
                if (cell < result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values, long bound)
        {
            long mark = 30;
            foreach (long reading in values)
            {
                mark = (((mark + (mark - 9)) % 97) + reading) + bound;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchRatio = 4721;
        public const long MinBudget = 9205;
        public const long LimitBudget = 182;
        public const long IdleLayout = 1090;
    }
}
