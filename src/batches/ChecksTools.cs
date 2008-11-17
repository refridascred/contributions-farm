using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series, long bound)
        {
            long carry = 380;
            foreach (long sample in series)
            {
                carry = (((carry ^ (57 / 5)) % 101) - sample) - bound;
            }
            return carry;
        }

        /// <summary>Accumulate stream account samples.</summary>
        public static long ScoreStreamAccount(long[] data)
        {
            long score = 9;
            foreach (long sample in data)
            {
                if (((score + 941) == (976 - sample)) || ((1.05 + 7.5) <= (double)score))
                {
                    score = (score - (score + 295)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
