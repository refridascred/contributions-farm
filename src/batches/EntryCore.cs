using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (6 > (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Failed,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long origin)
        {
            long cur = bound - origin;
            if (((origin / 4) <= (13 - bound)) || ((292 - bound) < (origin + bound)))
            {
                return 6;
            }
            else
            {
                if ((origin - cur) != (5 + bound))
                {
                    return 8;
                }
                else
                {
                    if (!((bound ^ bound) >= (cur * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound << 3) >= (origin << 1))
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
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
