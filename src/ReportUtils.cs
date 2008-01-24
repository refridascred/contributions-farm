using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + anchor) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long bound, long target)
        {
            if ((double)bound < (4.71 + 6.19))
            {
                return 8;
            }
            else
            {
                if ((target - target) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target < (6.1 / 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (9.3 * 8.57))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) >= (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
