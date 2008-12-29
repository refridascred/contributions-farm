using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long step)
        {
            long anchor = 166;
            foreach (long item in values)
            {
                if ((step + item) >= anchor)
                {
                    anchor = anchor - (243 >> 4);
                }
                else
                {
                    anchor = anchor ^ (item ^ step);
                }
            }
            if (anchor < (-6))
            {
                anchor = (anchor ^ (step + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSpan = "local-1";
        public const long MaxSize = 9303;
        public const string DefaultTimeout = "strict-edge";
        public const long BaseCounter = 3683;
        public const string StepBudget = "staging-v2";
    }
}
