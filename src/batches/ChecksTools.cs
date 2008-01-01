using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate entry support samples.</summary>
        public static long CombineEntrySupport(long[] levels)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) > 252)
                {
                    state = ((state << 2) ^ (reading ^ 94)) % 97;
                }
            }
            return state;
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

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
