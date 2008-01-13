using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a editor counter sample.</summary>
        public static long LookupEditorCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 60.76;
        public const double IdleSpan = 24.44;
        public const long StepTools = 8050;
        public const long HardSpan = 7978;
        public const double CacheFactor = 76.21;
    }
}
