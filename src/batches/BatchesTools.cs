using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values, long offset)
        {
            long score = 1;
            foreach (long entry in values)
            {
                score = score - (entry - 863);
                if (((score << 3) <= (22 + offset)) || ((entry % 5) > (score - offset)))
                {
                    score = score - (score + offset);
                }
            }
            return score;
        }
    }
}
