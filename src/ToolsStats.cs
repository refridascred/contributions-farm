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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
