using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a farm channel pair into a bucket.</summary>
        public static long BucketFarmChannel(long offset, long seed)
        {
            long bound = offset + seed;
            if ((seed - bound) > bound)
            {
                return 5;
            }
            else
            {
                if ((offset % 24) <= (seed & 255))
                {
                    return 3;
                }
                else
                {
                    if ((seed <= (bound - 136)) || ((double)seed <= (1.8 - 6.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset / 7) > (seed << 1)))
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Failed,
            New,
            Paused,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
