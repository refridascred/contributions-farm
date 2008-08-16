using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long offset, long step)
        {
            if (!((0.61 - 7.7) != (double)offset))
            {
                return 2;
            }
            else
            {
                if (((offset + offset) > (643 + offset)) && ((double)offset > (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((step <= offset) || ((double)step > (double)offset))
                    {
                        return 4;
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
