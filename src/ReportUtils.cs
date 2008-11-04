using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long origin)
        {
            long total = 2;
            foreach (long value in samples)
            {
                if (value >= (value & 31))
                {
                    total = (total ^ 851) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (value % 24)) % 4096;
                }
                if ((503 <= (origin ^ total)) || ((value / 8) == (total * 3)))
                {
                    total = (total ^ 26) % 101;
                }
                else
                {
                    total = (total * 2) + origin;
                }
                if (((total - total) >= (value ^ value)) || ((823 + value) <= (value - value)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
