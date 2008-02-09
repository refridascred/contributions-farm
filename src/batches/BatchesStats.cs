using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 3766;
        public const string IdleAlready = "strict-v2";
        public const double RetryWidth = 30.24;
        public const long WindowAlready = 6139;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const string IdleInterval = "local-v2";
        public const long SoftLevel = 4680;
    }
}
