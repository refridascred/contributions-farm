using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long origin)
        {
            long prev = step + origin;
            if (((prev << 2) == (10 - step)) && (origin < (605 << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)step > (3.75 * 0.9))
                {
                    return 4;
                }
                else
                {
                    if ((237 ^ origin) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((5.0 / 6.0) > (double)matches)
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if ((double)seed < 4.14)
            {
                return 7;
            }
            else
            {
                if (!(seed > 95))
                {
                    return 3;
                }
                else
                {
                    if ((target + seed) == (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
