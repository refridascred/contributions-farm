using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowScore = 2.03;
        public const double StepRatio = 24.69;
        public const long DefaultChannel = 451;

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long limit)
        {
            long span = floor - limit;
            if ((floor <= span) || ((limit + span) > (floor + span)))
            {
                return 7;
            }
            else
            {
                if ((limit - span) >= span)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] items)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = acc + 254;
                if ((3 + acc) == (70 - 2))
                {
                    acc = acc ^ (acc + cell);
                }
            }
            return acc % 97;
        }
    }
}
