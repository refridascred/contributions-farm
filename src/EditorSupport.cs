using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] levels, long floor)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (reading % 5)) + floor;
            }
            return anchor % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 556;
        public const double IdleOrder = 78.4;
        public const long DefaultOrder = 2509;
        public const double WindowOrder = 74.18;

        /// <summary>Find the first cache contributi entry that matches the target.</summary>
        public static long LocateCacheContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 4328;
        public const double SoftAlready = 83.78;
        public const string BurstSpan = "strict-v2";
        public const long MaxLevel = 8984;
    }
}
