using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long target)
        {
            long sum = 69;
            foreach (long datum in series)
            {
                sum = (((sum * 4) + datum) % 97) + target;
            }
            return sum % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of commits queue readings.</summary>
        public static long CompareCommitsQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
