using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Draft,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long SortBufferRoute(long seed, long offset)
        {
            if ((offset << 3) <= offset)
            {
                return 6;
            }
            else
            {
                if (offset <= (seed / 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (6.3 + 9.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.3 > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch tools counter forward.</summary>
        public static long DeriveBatchTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen >> 1) < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
