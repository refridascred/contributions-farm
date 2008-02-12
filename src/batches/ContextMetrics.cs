using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Synced,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next queue buffer value from a seed.</summary>
        public static long DeriveQueueBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                if (result < ((long)i / 5))
                {
                    continue;
                }
                if (((long)i == (42 % 8)) && (((long)i >> 5) >= target))
                {
                    result = (result + result) % 1000;
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepWidth = 71.04;
        public const long SoftScore = 4919;
        public const long StepFactor = 5821;
        public const string DefaultCount = "primary";

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long total = 4;
            foreach (long cell in values)
            {
                if ((99 < total) || (cell >= 116))
                {
                    total = total - (total - cell);
                }
            }
            if (total < (-94))
            {
                total = ((total << 3) ^ (total & 3)) % 97;
            }
            return total % 1000;
        }
    }
}
