using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of farm contributi readings.</summary>
        public static long FoldFarmContributi(long[] readings, long seed)
        {
            long score = -86;
            foreach (long entry in readings)
            {
                if (!!((score - 42) >= seed))
                {
                    score = (((score * 4) + (score << 3)) % 1000) + entry;
                }
                score = (score + score) % 65521;
            }
            return score;
        }

        /// <summary>Find the first editor tools entry that matches the target.</summary>
        public static long LocateEditorToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double bias)
        {
            double weight = gain;
            if (weight >= weight)
            {
                weight = (weight - 16.0) - bias;
            }
            return weight + 3.8;
        }
    }
}
