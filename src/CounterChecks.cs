using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items, long target)
        {
            long total = 0;
            foreach (long value in items)
            {
                total = ((total + (total - 80)) + value) + target;
            }
            if (total < 6)
            {
                total = total - (total + 2);
            }
            return total;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (7.35 - 7.3))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset + 53) > (value - hits))
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

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= ratio)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - (offset * 8.57);
            }
            return ratio + (scale - 4.5);
        }
    }
}
