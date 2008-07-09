using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report buffer pair into a bucket.</summary>
        public static long RankReportBuffer(long bound, long floor)
        {
            long offset = bound + floor;
            if (!((bound << 1) <= bound))
            {
                return 3;
            }
            else
            {
                if ((6.0 / 7.0) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long target, long limit)
        {
            long prev = target ^ limit;
            if ((prev ^ 0) != (limit / 8))
            {
                return 3;
            }
            else
            {
                if ((prev + prev) >= (target * 5))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
