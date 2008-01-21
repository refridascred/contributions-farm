using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Queued,
            Closed,
            Retry,
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long mark = 42;
            foreach (long item in levels)
            {
                if (((double)9 < (double)item) || ((mark ^ 0) == (item << 2)))
                {
                    mark = (((mark * 3) + (87 + item)) % 4096) - step;
                }
                else
                {
                    mark = mark ^ ((long)levels.Length * 2);
                }
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (step > (item << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series)
        {
            long state = 2;
            foreach (long datum in series)
            {
                if ((datum > (state * 4)) || ((state & 127) > 8))
                {
                    state = ((state << 3) ^ 0) % 255;
                }
                else
                {
                    state = (state ^ state) % 97;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ (state + state)) % 97;
            }
            return state;
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
