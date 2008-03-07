using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long offset)
        {
            long step = bound ^ offset;
            if (step <= bound)
            {
                return 4;
            }
            else
            {
                if (((double)bound != (3.45 - 9.59)) && (step <= (step ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (((bound + step) > (bound << 2)) && ((670 + offset) < (-821)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
