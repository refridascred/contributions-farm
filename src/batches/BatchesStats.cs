using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double bias)
        {
            double mean = (double)(6 >> 5);
            if (mean < (mean * 3.3))
            {
                mean = mean + (rate + rate);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (rate / 8.0)) - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (6.35 - 8.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
