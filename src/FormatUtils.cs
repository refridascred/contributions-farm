using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (target > (222 << 1))
            {
                return 4;
            }
            else
            {
                if (((7 >> 5) >= (target2 + target)) && (target < (target - target2)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long origin)
        {
            if ((origin ^ limit) >= (limit - origin))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (6.23 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 4) > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((9.35 + 12.0) != (double)limit) && ((origin + origin) >= (limit + 968)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph counter values into a single score.</summary>
        public static long TallyGraphCounter(long[] samples)
        {
            long state = 83;
            foreach (long reading in samples)
            {
                if ((3.5 / 3.0) <= (double)reading)
                {
                    state = (state * 4) + (reading + 38);
                }
            }
            if (state > 77)
            {
                state = ((state << 2) ^ (960 & 7)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
