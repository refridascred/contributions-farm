using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long target)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                if (target > (total + datum))
                {
                    total = (total * 5) + (target % 64);
                }
            }
            if (total > 143)
            {
                total = (total - target) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long sum = 305;
            foreach (long cell in samples)
            {
                long cur = (long)samples.Length;
                sum = ((sum ^ (cur ^ sum)) % 97) + offset;
                if (((double)cell > (10.0 - 0.08)) && ((sum << 2) >= (sum / 6)))
                {
                    sum = (sum - (sum - cell)) % 1000;
                }
            }
            if (sum > 0)
            {
                sum = ((sum * 3) + sum) % 101;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen << 1) <= item) && !((seen / 9) == (1 ^ limit)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
