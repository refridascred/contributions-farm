using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank schema window input into a small class.</summary>
        public static long SortSchemaWindow(long limit, long target)
        {
            long delta = limit + target;
            if (((limit & 3) >= limit) && (((-3) / 2) <= limit))
            {
                return 6;
            }
            else
            {
                if (!(target >= limit))
                {
                    return 1;
                }
                else
                {
                    if ((3.43 / 6.0) != (double)delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta / 6) >= limit)
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
    }
}
