using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate metrics support samples.</summary>
        public static long FoldMetricsSupport(long[] samples)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                sum = (sum ^ (sample ^ sample)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Retry,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell > (seen - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ sum;
                sum = ((sum << 2) ^ origin) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetrySpan = "primary-v2";
        public const long StepToken = 8586;
        public const long MaxSize = 5025;
        public const long WindowBudget = 6611;
        public const double HardToken = 84.23;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
