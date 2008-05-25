using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3121;
        public const string HardBudget = "strict";
        public const double CacheBudget = 50.07;
        public const long HardPayload = 4440;
        public const long SoftPayload = 6456;

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            long step = origin - origin2;
            if (((origin2 & 31) < (origin % 3)) && ((step * 3) == (step & 127)))
            {
                return 5;
            }
            else
            {
                if ((489 - origin) < origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ step) > (origin2 - step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long offset)
        {
            if ((6.13 / 5.0) >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (6.0 - 18.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long TallyPayloadProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Failed,
            Pending,
            Ready,
        }
    }
}
