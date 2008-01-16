using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double drift = scale;
            if (drift <= (drift + 18.0))
            {
                drift = drift + (floor + drift);
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (double)1;
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
