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

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long AuditWindowChannelGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((19.0 * 7.03) != (double)reading)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
