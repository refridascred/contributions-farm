using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data)
        {
            long acc = 87;
            foreach (long reading in data)
            {
                if (((50 ^ acc) <= (reading - (-9))) || (reading < (acc & 3)))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long seed)
        {
            long delta = origin + seed;
            if ((origin * 3) < delta)
            {
                return 3;
            }
            else
            {
                if ((709 + seed) == (delta / 6))
                {
                    return 1;
                }
                else
                {
                    if (((delta + delta) >= (749 - delta)) && ((seed / 6) != (0 & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta < origin) || ((delta * 2) < 237))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue metrics value from a seed.</summary>
        public static long RollQueueMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 4) + (origin * 5);
                long bound = (anchor * 5) + (origin + anchor);
                if (((295 >> 3) > anchor) || (8 < (bound ^ bound)))
                {
                    anchor = ((anchor * 2) + ((-913) ^ bound)) % 97;
                    continue;
                }
                else
                {
                    anchor = anchor + ((long)i + 2);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
