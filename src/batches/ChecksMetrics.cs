using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + ((long)i % 2);
                if ((double)bound <= (7.0 - 16.0))
                {
                    break;
                }
                else
                {
                    sum = sum ^ (bound * 5);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Paused,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double weight2 = weight;
            return (weight2 + weight) + offset;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long offset)
        {
            long delta = origin ^ offset;
            if (((16.0 * 6.02) != (double)delta) || ((origin + delta) <= offset))
            {
                return 6;
            }
            else
            {
                if ((delta % 10) > origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= (15.0 + 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + delta) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5984;
        public const long WindowEntry = 5338;
        public const double WindowInterval = 31.79;
        public const long RetryRatio = 264;
        public const long MinEntry = 3910;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
