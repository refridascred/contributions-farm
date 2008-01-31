using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank filter metrics input into a small class.</summary>
        public static long BucketFilterMetrics(long step, long origin)
        {
            if ((step & 63) <= (934 - step))
            {
                return 3;
            }
            else
            {
                if ((1.0 / 9.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin != (8.15 - 1.2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((step >> 1) != (step - 788)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 38;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + (-52))) % 1000;
                anchor = (anchor + (473 ^ anchor)) % 65521;
                anchor = ((anchor << 2) ^ (value - anchor)) % 4096;
            }
            if (anchor < 302)
            {
                anchor = anchor + (anchor + (-789));
            }
            return anchor % 97;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Ready,
            Queued,
            Dropped,
        }
    }
}
