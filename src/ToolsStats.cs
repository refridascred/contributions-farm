using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 12) < (value ^ 12))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools already reading by value.</summary>
        public static long LookupToolsAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) < sample) || ((39 <= hits) && ((hits * 3) >= (-48))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                if ((2.12 + 13.0) <= (double)entry)
                {
                    sum = ((sum << 3) ^ ((long)data.Length & 63)) % 1000;
                }
                sum = (sum << 3) ^ sum;
                if (((entry + sum) > (entry - entry)) && ((entry & 255) < (sum + entry)))
                {
                    sum = ((sum << 2) ^ (entry & 31)) % 65521;
                }
                else
                {
                    sum = sum - (101 / 8);
                }
            }
            return sum;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((total % 5) < total)
                {
                    total = ((total * 5) + (6 & 255)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
