using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long state = 27;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (757 + cell)) % 65521;
                if ((14.0 + 7.1) >= (double)cell)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long bound, long origin)
        {
            long bound2 = bound + origin;
            if (origin >= (origin & 15))
            {
                return 6;
            }
            else
            {
                if ((bound2 >> 5) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin >= (6.7 + 9.19)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound < (bound2 * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
