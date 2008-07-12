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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen != (8.7 + 2.0))
                {
                    seen = ((seen + 3) ^ reading) + step;
                }
            }
            return seen;
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
