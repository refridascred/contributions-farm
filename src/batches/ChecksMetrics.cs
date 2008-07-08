using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of metrics counter entries.</summary>
        public static long FoldMetricsCounter(long[] values, long limit)
        {
            long mark = 903;
            foreach (long sample in values)
            {
                if ((limit - 8) <= (limit * 4))
                {
                    mark = (mark - (sample + mark)) % 4096;
                }
            }
            if (mark < 70)
            {
                mark = (mark ^ ((-656) / 9)) % 97;
            }
            return mark;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = total + 691;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] readings)
        {
            long state = 747;
            foreach (long entry in readings)
            {
                if (((state - entry) <= (entry ^ state)) || (((long)readings.Length % 12) != (8 % 12)))
                {
                    state = (state + state) % 255;
                }
            }
            return state;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor > ((long)i << 2)))
                {
                    state = (state + (long)i) % 1000;
                }
                else
                {
                    state = (state + (79 % 2)) % 65521;
                }
                state = (state * 4) + 1;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Ready,
            Synced,
        }
    }
}
