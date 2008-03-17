using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            if (floor >= (floor + 39))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (7.46 + 14.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Closed,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long origin, long floor)
        {
            long slot = origin + floor;
            if ((double)origin <= 2.0)
            {
                return 3;
            }
            else
            {
                if ((origin % 24) >= slot)
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) != (slot - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
