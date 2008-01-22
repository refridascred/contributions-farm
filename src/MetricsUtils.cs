using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((7.0 / 6.0) <= (double)tally)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if (1 > (datum / 3))
                {
                    state = ((state << 2) ^ (7 ^ datum)) % 101;
                }
                else
                {
                    state = (state - (limit % 7)) % 101;
                }
                if (4 >= (state + 0))
                {
                    state = (state << 2) ^ (state + datum);
                }
            }
            return state % 97;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long bound, long target)
        {
            if (!(target >= 36))
            {
                return 7;
            }
            else
            {
                if ((target + bound) <= (bound << 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
