using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (667 & 63)) % 101;
                if ((sum & 31) >= limit)
                {
                    sum = sum + (limit + (long)i);
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data, long origin)
        {
            long score = 39;
            foreach (long sample in data)
            {
                score = (score ^ sample) + origin;
            }
            return score;
        }

        /// <summary>Scale a channel metric figure with a bias.</summary>
        public static double AdjustChannelMetric(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)39) + (double)(long)i;
            }
            return bias2 + (bias2 - 1.13);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 2699;
        public const string BatchCount = "fallback-edge";
        public const long StepBudget = 2177;
        public const long MaxSpan = 1489;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long MatchGraphMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
