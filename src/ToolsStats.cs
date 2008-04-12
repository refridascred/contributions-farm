using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a format counter counter forward.</summary>
        public static long DeriveFormatCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((total % 2) <= (limit >> 2))
                {
                    total = ((total * 5) + ((-76) - (-85))) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double drift = (bias + bias) * 5.4;
            if (drift <= (drift * 5.05))
            {
                drift = (drift + bias) + bias2;
            }
            else
            {
                drift = drift + 3.09;
            }
            return drift - (bias - 19.0);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)count > (double)datum) && ((3.6 - 9.18) != (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches session samples.</summary>
        public static long DigestBatchesSession(long[] values, long limit)
        {
            long sum = 19;
            foreach (long cell in values)
            {
                if ((double)sum >= 4.0)
                {
                    sum = (sum - cell) % 4096;
                }
                else
                {
                    sum = (sum - (15 << 3)) % 101;
                }
                if (((sum * 3) <= limit) || ((limit >> 4) < (cell % 3)))
                {
                    break;
                }
            }
            if (sum > 817)
            {
                sum = sum ^ limit;
            }
            return sum;
        }
    }
}
