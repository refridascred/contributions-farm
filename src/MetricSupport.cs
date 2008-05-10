using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long origin)
        {
            if ((origin + origin) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((double)step < (4.7 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if (((origin << 3) != (step * 4)) && ((9 ^ step) <= ((-6) + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
