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

        /// <summary>Audit command metric readings against a rule.</summary>
        public static long MeasureCommandMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(tally >= (tally - 79)) || ((tally <= (62 ^ tally)) || ((3.6 * 6.1) <= (double)tally)))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
