using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchDepth = 2338;
        public const long StepInterval = 4566;
        public const string StepSize = "open";

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double bias2 = 3.9;
            if (bias2 < (double)4)
            {
                bias2 = ((bias2 - 2.05) - bias) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (4.0 * 6.6)) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (target & 15)) % 4096;
                state = state + state;
                if (((state + 2) != (597 + 954)) || ((89 & 127) <= (state - state)))
                {
                    state = ((state << 3) ^ (5 + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
