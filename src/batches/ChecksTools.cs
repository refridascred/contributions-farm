using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double load = bias;
            if (load < (5.4 * 1.44))
            {
                load = load + (gain / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load / 6.0)) + (double)(long)i;
            }
            return load + (load * 8.1);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Active,
            Closed,
            Paused,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long limit2)
        {
            if (limit >= limit2)
            {
                return 4;
            }
            else
            {
                if ((limit2 + limit2) == (limit - limit))
                {
                    return 6;
                }
                else
                {
                    if ((27 >> 2) <= (957 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
