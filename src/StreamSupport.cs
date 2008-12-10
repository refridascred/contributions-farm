using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset - gap) <= (gap * 4))
            {
                return 0;
            }
            else
            {
                if ((offset - gap) > (offset << 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (5.0 - 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (gap > (gap + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 7621;
        public const long BaseLevel = 5278;
        public const long MinLevel = 5188;
        public const long LimitOrder = 7038;
        public const string SoftOrder = "staging";

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long bound)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((((sum << 2) ^ (sum + sum)) % 255) + sample) + bound;
            }
            return sum % 4096;
        }
    }
}
