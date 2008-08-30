using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2821;
        public const long MaxChannel = 8903;
        public const long DefaultChannel = 1637;
        public const long SoftChannel = 426;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long offset, long step)
        {
            long span = offset ^ step;
            if (((-8) + span) > (offset / 5))
            {
                return 8;
            }
            else
            {
                if ((span + 117) != (2 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (double)step) && ((step - step) != (731 - 58)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > (9.16 * 0.89))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
