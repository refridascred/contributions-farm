using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long score = 891;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (5.64 - 6.0)))
                {
                    score = ((score + (datum / 4)) % 65521) + floor;
                }
            }
            if (score > 284)
            {
                score = ((score << 3) ^ (score % 24)) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings, long seed)
        {
            long result = 84;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result ^ (148 + sample)) % 4096) + (long)i2;
                }
                if ((seed + result) > (-779))
                {
                    result = result - (seed + 16);
                }
            }
            if (result < 122)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 65521;
        }
    }
}
