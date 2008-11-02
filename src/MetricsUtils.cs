using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long result = 84;
            foreach (long cell in data)
            {
                result = result + cell;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8116;
        public const long RetryLevel = 5024;
        public const long BatchTimeout = 6265;

        /// <summary>Audit support context readings against a rule.</summary>
        public static long TallySupportContextMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(target <= (reading + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph support pair into a bucket.</summary>
        public static long SortGraphSupport(long origin, long seed)
        {
            if (origin <= (seed + origin))
            {
                return 2;
            }
            else
            {
                if ((8.0 + 3.8) >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= (14.0 - 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (origin + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
