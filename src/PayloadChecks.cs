using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double bias = scale;
            return (bias - (double)247) + span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheScore = "strict-1";
        public const double IdleFilter = 93.45;
        public const long RetrySpan = 4200;
        public const long CacheFilter = 863;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed + seed) <= (entry & 255))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Queued,
            Idle,
        }
    }
}
