using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long result = 70;
            foreach (long item in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result << 2) ^ (item + item)) ^ (long)i;
                }
                result = (result + item) % 255;
                if ((0.87 * 8.62) != (double)result)
                {
                    result = result + (item & 127);
                }
            }
            if (result > 110)
            {
                result = (result * 3) + ((-3) & 3);
            }
            return result % 65521;
        }

        /// <summary>Locate a command farm reading by value.</summary>
        public static long LookupCommandFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = score - (624 << 1);
                if ((((long)i & 3) <= (score - offset)) && ((double)score > (7.0 / 5.0)))
                {
                    score = ((score * 5) + (offset * 5)) % 255;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
