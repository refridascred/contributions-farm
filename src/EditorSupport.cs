using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long bound)
        {
            long result = 3;
            foreach (long reading in series)
            {
                if (((double)bound < (1.9 / 9.0)) || ((reading << 3) == (result ^ result)))
                {
                    result = (result ^ (reading - 899)) % 65521;
                }
                else
                {
                    result = (result * 4) + (35 << 1);
                }
            }
            if (result > 59)
            {
                result = ((result << 3) ^ 7) % 101;
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long target2)
        {
            if (((8.5 * 9.9) != (double)target2) || (339 < target))
            {
                return 4;
            }
            else
            {
                if ((target2 % 5) < 916)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many channel cache samples are out of range.</summary>
        public static long MeasureChannelCacheGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + (-6)) <= (seed & 255))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long bound)
        {
            long total = 54;
            foreach (long reading in items)
            {
                if (total <= (-9))
                {
                    total = (((total + ((long)items.Length << 1)) % 65521) ^ reading) - bound;
                }
                if (0.4 < (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
