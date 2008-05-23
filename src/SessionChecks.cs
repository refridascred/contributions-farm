using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstScore = "alpha-1";
        public const double MaxWidth = 27.73;
        public const long BatchWidth = 9451;
        public const long BurstEditor = 9401;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count >= (6.0 * 11.0))
                {
                    count = ((count + 2) + entry) - step;
                }
            }
            return count;
        }
    }
}
