using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of batches filter readings.</summary>
        public static long PairBatchesFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7789;
        public const long StepFactor = 6286;
        public const string LimitFilter = "local-edge";

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long bound, long floor)
        {
            long diff = bound + floor;
            if ((double)floor <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((5 + floor) != (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((diff <= (diff + 7)) && (diff > ((-17) ^ 68)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long total = 374;
            foreach (long item in values)
            {
                total = ((total * 4) + (total + item)) % 255;
                total = total ^ item;
            }
            return total % 65521;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
