using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = score - (offset / 8);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!!(sample >= (count + limit)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
