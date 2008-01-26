using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((8.77 / 8.0) != (double)target) && ((target + (-6)) > (score % 64)))
                {
                    score = ((score << 2) ^ (score / 4)) % 97;
                    score = (score * 3) + (target * 3);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowFactor = 18.23;
        public const double MinOrder = 49.57;
        public const double BaseOrder = 69.59;
        public const double StepSize = 6.84;
        public const double DefaultOrder = 70.92;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
