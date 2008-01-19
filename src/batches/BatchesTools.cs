using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long bound)
        {
            if (7 < (step * 5))
            {
                return 3;
            }
            else
            {
                if ((2.12 / 9.0) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 5) > (step % 16)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long sum = 464;
            foreach (long item in readings)
            {
                if ((sum << 2) < item)
                {
                    sum = (sum * 4) + (196 - 426);
                }
                if ((28 / 7) == (item & 127))
                {
                    break;
                }
            }
            if (sum < 800)
            {
                sum = (sum - (sum / 4)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!!(((long)data.Length << 3) <= matches))
                {
                    matches = ((matches + 3) ^ sample) + offset;
                }
            }
            return matches;
        }
    }
}
