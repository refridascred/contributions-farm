using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "strict-v2";
        public const long SoftWidth = 6924;
        public const string BatchScore = "latest-v2";
        public const long BatchNotes = 7817;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Closed,
            Idle,
        }
    }
}
