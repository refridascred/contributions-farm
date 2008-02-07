using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long offset, long limit)
        {
            long lane = offset ^ limit;
            if ((2.4 * 13.0) < (double)offset)
            {
                return 6;
            }
            else
            {
                if ((double)lane < (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - limit) <= (limit * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)lane < 5.4)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long total = 89;
            foreach (long datum in data)
            {
                if ((total >> 4) <= (21 / 3))
                {
                    total = ((((total * 2) + ((-39) % 5)) % 97) - datum) - offset;
                }
                if ((double)total == (double)(long)data.Length)
                {
                    break;
                }
            }
            if (total < 71)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }
    }
}
