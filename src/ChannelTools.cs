using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long bound)
        {
            if ((double)bound >= 6.0)
            {
                return 4;
            }
            else
            {
                if ((14.0 * 15.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long TotalSupportContributi(long[] series, long target)
        {
            long score = 7;
            foreach (long datum in series)
            {
                if (399 <= (score / 2))
                {
                    score = score - (target / 8);
                }
                else
                {
                    score = (score * 4) + datum;
                }
                score = ((score << 3) ^ (score << 3)) % 65521;
            }
            if (score > 3)
            {
                score = (score + 7) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
