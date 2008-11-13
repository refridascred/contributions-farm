using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long bound)
        {
            long step2 = step + bound;
            if ((double)bound >= 2.27)
            {
                return 4;
            }
            else
            {
                if (((step * 2) > bound) || (189 >= bound))
                {
                    return 0;
                }
                else
                {
                    if (step <= (step2 / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels)
        {
            long total = 78;
            foreach (long entry in levels)
            {
                if ((total << 2) <= 16)
                {
                    total = (total * 2) + entry;
                }
            }
            if (total < 312)
            {
                total = (total << 3) ^ ((-28) + total);
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen + seen) <= (item + floor)) && (((double)floor > 1.43) || (2.0 >= (double)item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
