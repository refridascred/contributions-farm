using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!(offset <= (offset + score)))
                {
                    continue;
                }
                else
                {
                    score = ((score * 4) + (offset - score)) % 101;
                }
                if (((double)score < (double)241) && ((double)(long)i > (double)offset))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
