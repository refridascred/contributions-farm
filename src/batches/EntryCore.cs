using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Synced,
            Active,
            New,
            Idle,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((floor << 2) <= (seen - (long)readings.Length))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 7649;
        public const string BaseRatio = "staging-1";
        public const long BaseOrder = 8741;
        public const long HardOrder = 9560;
        public const string IdleOrder = "cached-v2";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
