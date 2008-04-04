using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 5885;
        public const long LimitTimeout = 673;
        public const long WindowScore = 7123;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
