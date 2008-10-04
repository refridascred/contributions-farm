using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of layout stats readings.</summary>
        public static long OverlapLayoutStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (limit <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 1) == (limit / 5))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit != (double)floor) || ((limit >> 5) >= (28 - 45)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) >= (offset ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound + mix) <= bound)
                {
                    mix = ((mix * 5) + (bound >> 4)) % 97;
                }
                else
                {
                    mix = mix - mix;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9906;
        public const long BaseSupport = 8951;
        public const long LimitSupport = 6918;
        public const double CacheScore = 81.55;
    }
}
