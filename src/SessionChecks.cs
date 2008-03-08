using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                acc = (acc << 2) ^ (datum >> 2);
            }
            if (acc < 502)
            {
                acc = acc + origin;
            }
            return acc % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if ((double)72 >= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((double)floor > (16.0 - 3.53))
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor > (19.0 / 6.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + 132) >= (offset & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
