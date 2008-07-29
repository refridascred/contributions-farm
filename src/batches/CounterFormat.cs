using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate metrics support readings against a bound.</summary>
        public static bool GuardMetricsSupportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] values)
        {
            long score = 381;
            foreach (long entry in values)
            {
                if (((entry + score) < entry) && ((entry + entry) <= (77 / 4)))
                {
                    score = ((score * 3) + 11) % 97;
                }
            }
            if (score < 898)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }
    }
}
