using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings, long limit)
        {
            long mark = 759;
            foreach (long sample in readings)
            {
                if (mark > (sample - limit))
                {
                    mark = (mark * 4) + (limit ^ limit);
                    break;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = (mark ^ (limit + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long MeasureContributiBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((((-8) + count) != (669 << 3)) || ((double)count == (18.0 * 0.95))))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 23.81;
        public const double SoftTimeout = 74.04;
        public const double BaseCount = 85.56;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Ready,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
