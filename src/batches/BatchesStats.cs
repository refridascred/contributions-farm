using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long seed)
        {
            if ((origin - origin) <= (8 + seed))
            {
                return 7;
            }
            else
            {
                if ((origin + 27) != (seed + origin))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed > (5.6 + 1.1)) && ((double)origin >= (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
