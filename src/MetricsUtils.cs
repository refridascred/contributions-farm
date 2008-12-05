using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count & 1) != (count + cell)) && ((cell * 3) == (cell >> 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long seed)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((5.0 * 1.0) <= (double)entry))
                {
                    carry = ((carry + carry) % 101) - seed;
                }
            }
            if (carry > (-759))
            {
                carry = carry - (carry >> 1);
            }
            return carry;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin < (2.5 / 4.0))
                {
                    mix = ((mix * 3) + (mix / 2)) % 97;
                }
                mix = (mix + (long)i) % 65521;
                mix = (mix - (origin << 2)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
