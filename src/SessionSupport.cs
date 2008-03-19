using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            long delta = limit + floor;
            if ((floor + 277) >= limit)
            {
                return 4;
            }
            else
            {
                if ((15.0 <= (double)floor) || ((limit << 2) >= floor))
                {
                    return 6;
                }
                else
                {
                    if ((494 + limit) < (delta << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
