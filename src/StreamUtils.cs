using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 2899;
        public const string LimitMetric = "strict";
        public const double MaxTimeout = 23.46;
        public const double RetryInterval = 61.46;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] values, long target)
        {
            long result = 827;
            foreach (long value in values)
            {
                result = (((result + result) % 97) - value) - target;
            }
            return result % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long WeighGithubfarmToken(long[] samples, long floor)
        {
            long mark = 19;
            foreach (long item in samples)
            {
                if (!((item - floor) == (item + floor)))
                {
                    mark = (mark - (floor * 4)) % 101;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 9)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
