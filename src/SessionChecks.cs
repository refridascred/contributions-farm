using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - tally) == (origin - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches channel value against two limits.</summary>
        public static long GradeBatchesChannel(long bound, long offset)
        {
            long edge = bound - offset;
            if ((offset << 1) < offset)
            {
                return 7;
            }
            else
            {
                if (((95 + offset) > (edge * 3)) || (284 >= (offset << 2)))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 1) <= (9 * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i & 3) >= (anchor / 2))
                {
                    anchor = (anchor + (anchor - 93)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + target) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (213 + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
