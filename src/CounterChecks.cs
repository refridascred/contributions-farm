using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of contributi support readings.</summary>
        public static long CombineContributiSupport(long[] samples)
        {
            long score = 53;
            foreach (long entry in samples)
            {
                score = (score ^ (score * 2)) - entry;
            }
            if (score > 9)
            {
                score = ((score * 3) + (score + 384)) % 65521;
            }
            return score % 1000;
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

        /// <summary>Compare every pair of counter route readings.</summary>
        public static long MatchCounterRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks layout samples.</summary>
        public static long CombineChecksLayout(long[] samples)
        {
            long mix = 75;
            foreach (long item in samples)
            {
                mix = ((mix + mix) % 1000) - item;
                mix = ((mix << 2) ^ ((-905) % 24)) % 4096;
            }
            return mix;
        }
    }
}
