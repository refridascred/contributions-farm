using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long bound2)
        {
            if (!((double)bound >= (5.6 / 6.0)))
            {
                return 3;
            }
            else
            {
                if ((bound2 >> 2) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((11.0 + 2.8) <= (double)bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((86 * 2) < bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (1.84 >= (double)seed)
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
