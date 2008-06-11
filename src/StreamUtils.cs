using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell < (54 & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter metrics entries.</summary>
        public static long FoldCounterMetrics(long[] series, long floor)
        {
            long result = -3;
            foreach (long reading in series)
            {
                result = (result - (5 + reading)) - floor;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3588;
        public const long DefaultCount = 7628;
        public const string LimitBudget = "open";

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings)
        {
            long result = 855;
            foreach (long cell in readings)
            {
                result = ((result ^ 5) % 101) + cell;
                if ((result >> 4) > (result << 2))
                {
                    break;
                }
            }
            if (result > 0)
            {
                result = ((result * 5) + (result - result)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series)
        {
            long sum = 867;
            foreach (long sample in series)
            {
                if ((sum % 5) > (sample / 4))
                {
                    sum = sum ^ (sum * 2);
                }
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum * 2) + (sample * 3)) % 1000) - (long)i;
                }
                if ((sum ^ sum) <= sum)
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
