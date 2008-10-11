using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryCount = "open-edge";
        public const string MinEntry = "alpha";
        public const long DefaultEntry = 9760;
        public const long BaseEntry = 1286;

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ offset) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state + (state << 3)) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Ready,
            Paused,
        }
    }
}
