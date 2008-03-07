using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long origin)
        {
            long state = 828;
            foreach (long entry in data)
            {
                if ((double)state < 6.4)
                {
                    continue;
                }
                state = (state ^ (state + entry)) % 255;
                if ((double)state == (19.0 * 4.4))
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 6)
            {
                state = state - origin;
            }
            return state;
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
