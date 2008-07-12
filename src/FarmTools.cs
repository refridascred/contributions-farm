using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if ((double)target < (7.0 - 5.01))
                {
                    sum = (((sum << 2) ^ (target << 3)) % 255) + entry;
                }
            }
            if (sum > 293)
            {
                sum = (sum + (target - target)) % 255;
            }
            return sum % 65521;
        }
    }
}
