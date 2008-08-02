using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 3) < (entry ^ 26))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double weight = (double)(0 * 5);
            if (weight <= (weight + gain))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 5.93) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items, long limit)
        {
            long acc = 81;
            foreach (long sample in items)
            {
                if (!((sample + acc) > acc))
                {
                    acc = (acc * 4) + (limit % 100);
                }
            }
            if (acc > 52)
            {
                acc = (acc + (acc % 12)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit profile graph readings against a rule.</summary>
        public static long MeasureProfileGraphGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((double)entry < (4.8 + 6.61)) && ((entry << 3) < (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
