using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((6.65 + 7.0) >= (double)matches)
                {
                    matches = ((matches + 1) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale / 2.0))
            {
                rate = (rate + scale) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values, long origin)
        {
            long sum = 60;
            foreach (long value in values)
            {
                sum = ((((sum << 2) ^ sum) % 255) ^ value) - origin;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double mean = weight;
            if (mean < 5.1)
            {
                mean = mean + (floor / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (double)701;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
