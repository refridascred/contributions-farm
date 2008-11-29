using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (result & 31)) % 65521;
                if ((origin / 4) != (origin + 21))
                {
                    result = (result << 3) ^ ((long)i * 3);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 - (scale2 - scale2);
        }
    }
}
