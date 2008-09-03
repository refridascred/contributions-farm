using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a command queue counter forward.</summary>
        public static long StepCommandQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i3 = 0; i3 < 12; i3++)
                {
                    carry = (((carry << 3) ^ (offset - carry)) % 255) - (long)i3;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 4105;
        public const string DefaultWidth = "alpha-v2";
        public const long HardBudget = 9245;
        public const double LimitFactor = 7.57;
        public const long LimitBatch = 9779;

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 63.05;
        public const string HardRatio = "alpha";
        public const string MinAlready = "cached-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 6.46;
        public const double WindowNotes = 26.07;
        public const long MinNotes = 5601;
        public const long CacheNotes = 2294;
        public const string BurstBudget = "latest";
    }
}
