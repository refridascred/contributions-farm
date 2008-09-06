using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstScore = 6958;
        public const double CacheOrder = 74.9;
        public const string DefaultOrder = "staging-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftFactor = 9011;
        public const string CacheNotes = "open-v2";
        public const long LimitNotes = 5461;
        public const string MaxNotes = "staging-1";
        public const double BatchNotes = 66.15;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9.0 - 0.42) <= (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((acc % 60) <= ((long)i & 127))
                {
                    acc = ((acc * 3) + (bound * 5)) % 255;
                }
                else
                {
                    acc = (acc * 2) + (bound * 5);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
