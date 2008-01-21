using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long floor)
        {
            long sum = 83;
            foreach (long cell in series)
            {
                if (((sum ^ 3) > (sum ^ floor)) && ((cell - cell) > cell))
                {
                    sum = (sum << 3) ^ (floor * 4);
                }
                else
                {
                    sum = sum - floor;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state << 3) ^ (state ^ 7)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 5) + ((-54) - step)) % 1000) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long score = 56;
            foreach (long value in data)
            {
                score = ((score * 2) + (40 + value)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - offset;
        }
    }
}
