using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 4562;
        public const long MaxTimeout = 2130;
        public const string HardCount = "fallback";

        /// <summary>Measure how many tools token samples are out of range.</summary>
        public static long TallyToolsTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((7.62 * 8.4) < (double)tally) && ((double)tally > (double)20)) && (7.7 >= (double)tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i >> 5) > (long)i)
                {
                    carry = (carry << 2) ^ (long)i;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double drift = 7.3;
            if (drift >= (offset - weight))
            {
                drift = drift + (double)(-4);
            }
            return drift - weight;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
