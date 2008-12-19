using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate editor profile readings against a bound.</summary>
        public static bool VerifyEditorProfileBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item >= (item / 3))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            long delta = origin + seed;
            if ((2.21 / 3.0) > (double)delta)
            {
                return 0;
            }
            else
            {
                if (origin < (origin >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) <= (668 & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
