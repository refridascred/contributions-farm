using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitBudget = 6615;
        public const long RetryWidth = 8741;
        public const string MaxChecks = "stable-v2";
        public const long MinChecks = 7373;
        public const long BurstChecks = 9387;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long CountFormatMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + tally) < (sample + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
