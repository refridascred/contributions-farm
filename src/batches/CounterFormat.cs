using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long bound)
        {
            if (((bound & 255) == (6 + bound)) || (step >= (bound & 15)))
            {
                return 4;
            }
            else
            {
                if ((step ^ step) == (bound - step))
                {
                    return 8;
                }
                else
                {
                    if (((47 << 2) <= (step << 3)) || ((step + bound) > (bound % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a report tools counter forward.</summary>
        public static long IterateReportTools(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                if ((target + total) < (8 / 5))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
