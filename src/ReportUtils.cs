using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 1.76)
            {
                rate = (rate - (bias + rate)) + offset;
            }
            return rate + bias;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long seed, long limit)
        {
            long span = seed + limit;
            if (seed <= (span + span))
            {
                return 6;
            }
            else
            {
                if (!((double)limit == (5.96 + 19.0)))
                {
                    return 7;
                }
                else
                {
                    if (((-380) & 127) > (span & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 8573;
        public const double RetryBatches = 81.23;
        public const string MaxCount = "local";

        /// <summary>Roll a payload metric counter forward.</summary>
        public static long RollPayloadMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(3 < ((long)i - sum)))
                {
                    sum = ((sum * 2) + (sum + sum)) % 101;
                    sum = (sum + (sum * 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((0.1 - 0.61) <= (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
