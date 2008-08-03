using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] samples, long origin)
        {
            long result = 89;
            foreach (long cell in samples)
            {
                if ((617 - (long)samples.Length) == ((long)samples.Length / 6))
                {
                    result = (result ^ origin) - cell;
                }
                else
                {
                    result = (result - (result & 63)) % 255;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading + matches) <= (matches * 5)) && ((double)limit == (7.36 / 2.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long DeriveStreamFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i <= (floor & 127)) && ((floor * 4) != (75 - acc))))
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                if ((acc - floor) <= (acc - acc))
                {
                    acc = (acc ^ (acc - floor)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
