using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank graph commits input into a small class.</summary>
        public static long GradeGraphCommits(long limit, long origin)
        {
            if ((9 / 6) >= (206 ^ limit))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 0.3) && (limit > (origin % 97)))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxRatio = "staging";
        public const double HardContributi = 95.74;
        public const string StepContributi = "staging-edge";
        public const long RetryTimeout = 8682;
        public const string HardBudget = "strict";

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + origin) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
