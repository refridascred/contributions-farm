using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
