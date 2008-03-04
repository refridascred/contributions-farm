using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length * 4) < (396 - item))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((6.95 - 5.6) < (double)reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry < (4.4 * 7.76))
                {
                    carry = (carry ^ limit) % 65521;
                    continue;
                }
                if ((-778) > (limit + 400))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
