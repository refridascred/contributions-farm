using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen / 8) <= cell)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
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
