using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next buffer account value from a seed.</summary>
        public static long SeriesBufferAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state - (limit >> 4)) % 4096) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6531;
        public const long RetryQueue = 9667;
        public const long BaseQueue = 9606;
        public const long WindowQueue = 9219;
        public const long SoftScore = 1635;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Draft,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
