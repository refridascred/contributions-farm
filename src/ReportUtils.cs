using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i * 3) <= (seed + seed))
                {
                    mark = ((mark << 3) ^ (mark - seed)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series, long step)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if (((step ^ step) >= step) && ((step + step) >= (result >> 3)))
                {
                    result = (((result * 5) + result) % 4096) + cell;
                }
            }
            if (result > 901)
            {
                result = (result + 3) % 1000;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((7.56 + 17.0) >= (double)value) || ((double)value < (2.82 + 3.9)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Paused,
            Retry,
            Active,
            Done,
        }
    }
}
