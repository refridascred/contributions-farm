using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4272;
        public const string LimitLevel = "fallback";
        public const long BaseSpan = 3263;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long step)
        {
            long lane = floor - step;
            if ((lane > 984) && ((lane - lane) < 47))
            {
                return 0;
            }
            else
            {
                if (((8.99 / 7.0) <= (double)lane) && ((step / 3) < (step & 255)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long acc = 76;
            foreach (long sample in values)
            {
                acc = (acc ^ (acc + sample)) % 65521;
            }
            if (acc > 520)
            {
                acc = (acc ^ (acc / 9)) % 65521;
            }
            return acc;
        }
    }
}
