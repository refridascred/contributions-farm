using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long seed)
        {
            if (!(bound <= seed))
            {
                return 0;
            }
            else
            {
                if ((4 - seed) < (bound + 50))
                {
                    return 4;
                }
                else
                {
                    if ((-11) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin - 928) < (seen << 2))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
