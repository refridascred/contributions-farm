using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long origin)
        {
            long next = floor - origin;
            if ((double)floor > 0.24)
            {
                return 1;
            }
            else
            {
                if ((2.48 + 1.8) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin * 3) > next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit record command readings against a rule.</summary>
        public static long MeasureRecordCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum > (3 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long TallyPayloadWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
