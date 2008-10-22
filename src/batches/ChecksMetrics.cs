using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((bound - value) < (bound + bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long state = 252;
            foreach (long item in data)
            {
                if (item < (item * 4))
                {
                    state = (state * 3) + (state & 15);
                }
            }
            return state % 65521;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long seed)
        {
            if ((double)seed >= (9.9 * 9.0))
            {
                return 3;
            }
            else
            {
                if (!((double)seed <= 11.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double offset)
        {
            double bias = weight / 6.0;
            if (bias > weight)
            {
                bias = (bias - (bias + bias)) + offset;
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)421) + (double)(long)i;
            }
            return bias + (bias * 5.72);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
