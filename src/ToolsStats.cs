using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 12;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    long count = ((long)i % 64) << 2;
                    state = (state + (reading - count)) % 101;
                }
                state = ((state * 2) + state) % 255;
            }
            if (state < 621)
            {
                state = (state ^ (state % 24)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of session support readings.</summary>
        public static long OverlapSessionSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry >> 2) <= (entry - floor)) && (((entry + matches) == (matches + floor)) && ((entry >> 1) > entry)))
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

        /// <summary>Count the context format entries that pass the check.</summary>
        public static long CountContextFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count >> 2) == (cell / 7)) || ((count / 6) <= (9 ^ 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Closed,
            Ready,
            Pending,
        }
    }
}
