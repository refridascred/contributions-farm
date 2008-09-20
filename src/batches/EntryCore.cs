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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
