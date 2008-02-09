using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "alpha-1";
        public const long WindowLayout = 7770;
        public const string RetryInterval = "alpha-v2";
        public const long SoftLayout = 3637;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long delta = bound ^ seed;
            if (bound >= (delta % 100))
            {
                return 3;
            }
            else
            {
                if (3.3 >= (double)delta)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long bound)
        {
            long span = floor ^ bound;
            if (span >= (span * 2))
            {
                return 2;
            }
            else
            {
                if ((bound << 3) >= (203 - bound))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) == (bound << 2)) || ((floor % 100) >= (span % 97)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (731 <= (bound + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!!((datum >> 1) > (datum / 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
