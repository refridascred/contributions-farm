using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen >> 1) > (seen % 2))
                {
                    seen = ((seen + 3) - reading) - limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items, long offset)
        {
            long result = 54;
            foreach (long cell in items)
            {
                long next = result;
                if ((double)cell == (0.24 - 8.0))
                {
                    result = ((result - (next + cell)) % 97) - offset;
                }
                if ((cell << 1) <= cell)
                {
                    result = ((result * 5) + (result << 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.08;
        public const long MinFilter = 7413;
        public const double MinDepth = 22.21;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
