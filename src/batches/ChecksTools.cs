using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((origin ^ origin) > tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long state = 31;
            foreach (long cell in items)
            {
                state = (state + (5 - floor)) % 97;
                if ((713 + cell) <= (state % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
