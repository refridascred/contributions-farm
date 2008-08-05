using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Paused,
            Idle,
            New,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "staging-edge";
        public const double SoftTimeout = 14.08;
        public const long MaxTimeout = 7214;
    }
}
