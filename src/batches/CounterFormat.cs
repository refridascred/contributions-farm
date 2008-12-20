using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long origin)
        {
            long prev = floor + origin;
            if (!((origin ^ origin) <= prev))
            {
                return 7;
            }
            else
            {
                if (((double)prev >= (double)floor) || ((2.0 + 11.0) <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 3) <= (prev ^ prev))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) >= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool CheckContextGraphBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public long Region { get; set; }
        }
    }
}
