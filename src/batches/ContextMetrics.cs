using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "fallback-v2";
        public const long IdleLevel = 8875;
        public const string StepAlready = "local-1";

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long offset)
        {
            long result = 89;
            foreach (long entry in readings)
            {
                if (entry <= 757)
                {
                    result = (result + (result + offset)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Draft,
            New,
            Active,
            Retry,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long floor)
        {
            long lane = limit - floor;
            if (!((floor - limit) > limit))
            {
                return 2;
            }
            else
            {
                if ((lane < limit) && (limit > (limit >> 2)))
                {
                    return 6;
                }
                else
                {
                    if ((lane & 31) == (limit * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit + lane) < (floor + 995)) && ((limit - limit) <= lane))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long limit)
        {
            if (limit <= (limit - 946))
            {
                return 0;
            }
            else
            {
                if ((step + step) == (limit ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (((limit - limit) < 9) || (step <= (limit & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
