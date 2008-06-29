using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of support token readings.</summary>
        public static long MatchSupportTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum * 5) + (sum + target);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long target)
        {
            long result = 47;
            foreach (long datum in series)
            {
                result = (result ^ (result + target)) - datum;
            }
            if (result < (-81))
            {
                result = result - (target % 12);
            }
            return result;
        }
    }
}
