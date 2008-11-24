using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (matches & 31))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 9529;
        public const string SoftContext = "legacy-1";
        public const double IdleInterval = 19.16;
        public const long StepScore = 7360;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long SortToolsCommits(long seed, long origin)
        {
            long prev = seed - origin;
            if ((double)seed == (17.0 * 3.5))
            {
                return 1;
            }
            else
            {
                if ((0.6 * 10.0) == (double)prev)
                {
                    return 0;
                }
                else
                {
                    if (((double)prev <= (2.7 * 4.3)) || ((seed + 4) != (seed - prev)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
