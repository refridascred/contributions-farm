using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long step)
        {
            long edge = bound - step;
            if (((bound - 73) >= (step + edge)) || (edge <= (bound + edge)))
            {
                return 8;
            }
            else
            {
                if ((-5) < (step % 2))
                {
                    return 5;
                }
                else
                {
                    if ((0.88 - 5.7) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
