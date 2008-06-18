using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long bound)
        {
            long next = target - bound;
            if (!((double)bound == (7.0 + 5.67)))
            {
                return 5;
            }
            else
            {
                if ((target * 3) != (target / 9))
                {
                    return 0;
                }
                else
                {
                    if ((bound + next) <= next)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)bound == (0.9 / 9.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long limit)
        {
            if (18.0 >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (((double)bound < 20.0) && ((double)bound != (2.32 - 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                long diff = state;
                state = ((state * 4) + (diff - state)) % 97;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank metric queue input into a small class.</summary>
        public static long BucketMetricQueue(long target, long seed)
        {
            if (((target - (-611)) < (target + seed)) || ((seed - 215) != (seed + target)))
            {
                return 7;
            }
            else
            {
                if (((-72) + seed) >= 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
