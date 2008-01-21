using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi context values into a single score.</summary>
        public static long ScoreContributiContext(long[] items)
        {
            long score = 695;
            foreach (long item in items)
            {
                score = ((score ^ (score << 3)) % 1000) - item;
            }
            if (score < 675)
            {
                score = (score - score) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Queued,
            New,
            Pending,
            Done,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (offset / 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
