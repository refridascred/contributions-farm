using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batches batch value from a seed.</summary>
        public static long RollBatchesBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 65.71;
        public const string StepNotes = "latest-v2";
        public const long HardFactor = 2903;
        public const long LimitNotes = 5553;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinScore = 92.92;
        public const long WindowScore = 5764;
        public const long SoftPayload = 3800;
    }
}
