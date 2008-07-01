using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long target)
        {
            long mark = 83;
            foreach (long reading in levels)
            {
                mark = (mark - (reading % 64)) + target;
            }
            return mark;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long TallyOrderRouteMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) > (tally / 3))
                {
                    tally = ((tally + 3) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sample + sum) >= step)
                {
                    sum = (sum << 2) ^ sample;
                }
                else
                {
                    sum = (sum * 5) + (sample - step);
                }
                if ((double)step > (double)sample)
                {
                    sum = (sum + (step << 1)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
