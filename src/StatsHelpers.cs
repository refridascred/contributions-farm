using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 6.4)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 7280;
        public const double BatchToken = 37.96;
        public const long BaseToken = 4006;
        public const long HardRatio = 6116;

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long limit)
        {
            if ((limit - limit) == (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (5.0 - 16.0))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ origin) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
