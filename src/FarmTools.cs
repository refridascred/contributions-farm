using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long target)
        {
            long edge = seed - target;
            if ((edge >> 1) < edge)
            {
                return 8;
            }
            else
            {
                if (((9 - edge) > 5) || (2 > (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long mix = 60;
            foreach (long cell in data)
            {
                if (((mix - mix) > 38) && ((cell % 7) > (cell % 10)))
                {
                    mix = (mix * 3) + cell;
                }
                else
                {
                    mix = (mix - (80 + cell)) % 101;
                }
            }
            return mix;
        }
    }
}
