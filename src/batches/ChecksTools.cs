using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already order samples.</summary>
        public static long CombineAlreadyOrder(long[] series, long bound)
        {
            long score = 81;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((((score * 2) + (0 >> 5)) % 255) - (long)i) - cell;
                }
                if ((double)bound <= (double)(long)series.Length)
                {
                    score = ((score * 3) + (score + 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Roll a notes profile counter forward.</summary>
        public static long SeriesNotesProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
