using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long limit)
        {
            long gap = origin ^ limit;
            if (((55 + gap) > gap) && ((origin ^ limit) == (5 & 63)))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) <= (origin - limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long mark = -304;
            foreach (long reading in samples)
            {
                if (!(mark < (reading + reading)))
                {
                    mark = ((mark * 4) + (limit >> 5)) % 101;
                }
                if (limit >= (limit + limit))
                {
                    continue;
                }
                mark = ((mark << 2) ^ (limit << 1)) % 4096;
            }
            if (mark > 3)
            {
                mark = ((mark * 2) + 45) % 255;
            }
            return mark;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
