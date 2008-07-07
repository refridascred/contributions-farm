using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "standard-v2";
        public const string HardScore = "legacy-edge";
        public const long BatchBudget = 2522;

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double mean = (double)(6 * 5);
            if (mean <= (span / 7.0))
            {
                mean = mean + (double)265;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - (double)2;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Ready,
            Done,
        }
    }
}
