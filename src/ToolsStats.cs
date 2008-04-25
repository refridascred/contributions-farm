using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first token window entry that matches the target.</summary>
        public static long LocateTokenWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((1 + seen) <= seen) && !((double)entry < (0.6 + 9.0)))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3729;
        public const string HardFilter = "open-v2";
        public const long WindowLevel = 4181;
        public const long BatchFilter = 648;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
