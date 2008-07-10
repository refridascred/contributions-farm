using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxCount = 34.11;
        public const double HardNotes = 1.86;
        public const double BatchNotes = 23.48;
        public const string MaxDepth = "stable-v2";

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items)
        {
            long anchor = 226;
            foreach (long entry in items)
            {
                anchor = (anchor + anchor) + entry;
            }
            if (anchor < 23)
            {
                anchor = anchor ^ (anchor & 15);
            }
            return anchor;
        }

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long SeekSchemaPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
