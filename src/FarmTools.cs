using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                sum = ((sum + (sum - sum)) % 97) - sample;
            }
            if (sum > 83)
            {
                sum = ((sum << 3) ^ (471 + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (14.0 < (double)entry)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
