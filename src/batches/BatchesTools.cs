using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 48) <= (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
