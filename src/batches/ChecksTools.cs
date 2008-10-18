using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((double)limit >= 1.8) && (((long)i >> 4) >= ((long)i % 7)))
                {
                    score = (score - (long)i) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (limit << 1)) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long offset)
        {
            if (2.6 <= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((514 >= (seed & 1)) && ((offset + seed) > (offset << 2)))
                {
                    return 8;
                }
                else
                {
                    if (seed < (seed - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
