using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a stream batch reading by value.</summary>
        public static long LookupStreamBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7674;
        public const long SoftTimeout = 87;
        public const long MinSupport = 8630;
        public const long BaseScore = 3781;

        /// <summary>Classify a route editor pair into a bucket.</summary>
        public static long ClassifyRouteEditor(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((bound + bound) >= (edge >> 5))
            {
                return 3;
            }
            else
            {
                if (4.0 > (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (((bound & 31) <= (bound + bound)) && ((seed << 2) != (bound - edge)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 98.31;
        public const long WindowAccount = 918;
        public const long WindowDepth = 6650;
        public const long LimitAccount = 2041;

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long AuditAlreadyGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((datum + 926) >= (count - datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
