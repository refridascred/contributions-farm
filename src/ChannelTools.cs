using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a metrics schema pair into a bucket.</summary>
        public static long SortMetricsSchema(long target, long seed)
        {
            if (!((target & 15) < (target % 24)))
            {
                return 2;
            }
            else
            {
                if (target > seed)
                {
                    return 3;
                }
                else
                {
                    if (seed > ((-1) << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((579 >> 2) != (seed << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor ^ (target & 31);
                if (!((target > (anchor - anchor)) || ((16.0 + 12.0) <= (double)anchor)))
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = anchor + (anchor - 3);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
