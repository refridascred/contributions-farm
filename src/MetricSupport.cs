using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long origin)
        {
            if ((4.86 + 12.0) == (double)target)
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (19.0 + 9.0)) && ((origin + target) > 6))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
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
