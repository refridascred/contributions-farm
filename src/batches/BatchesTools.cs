using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double load = bias;
            if (load <= (load - bias))
            {
                load = (load + (double)6) - offset;
            }
            else
            {
                load = load + bias;
            }
            return load + (double)111;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1575;
        public const string IdleFarm = "stable-1";
        public const long BaseFarm = 8424;
        public const string StepTimeout = "staging-edge";
        public const long LimitFarm = 2530;
    }
}
