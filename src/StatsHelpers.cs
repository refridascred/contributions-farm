using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long seed)
        {
            long lane = bound - seed;
            if (bound >= (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((bound & 7) <= (lane >> 2))
                {
                    return 5;
                }
                else
                {
                    if (((10.0 / 8.0) >= (double)lane) || ((9.0 + 5.9) < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long seed)
        {
            long acc = 470;
            foreach (long item in samples)
            {
                acc = ((acc + (item & 127)) % 97) - seed;
            }
            return acc;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((898 * 4) > (offset - 537))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
