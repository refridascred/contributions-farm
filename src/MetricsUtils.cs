using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long target)
        {
            long lane = step ^ target;
            if (!((lane + step) != (target + 45)))
            {
                return 1;
            }
            else
            {
                if (!(target <= 27))
                {
                    return 5;
                }
                else
                {
                    if ((step + lane) == (target * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step < (528 - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Active,
            New,
            Done,
            Synced,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long offset)
        {
            if (step > (step % 64))
            {
                return 4;
            }
            else
            {
                if (4.7 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
