using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + score) <= score)
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (score + limit)) % 101;
                }
                score = score + (limit - score);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
