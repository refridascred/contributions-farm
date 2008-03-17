using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long DeriveCounterContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark - (origin << 2)) % 4096;
                mark = (mark - (mark * 3)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((origin - sum) > (-22)) && (484 <= (sum + origin)))
                {
                    sum = sum ^ ((long)i % 100);
                }
                if (!(sum < (64 >> 3)))
                {
                    sum = (sum ^ (sum - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum & 127) != (901 - 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a record layout counter forward.</summary>
        public static long IterateRecordLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                long delta = (1 + step) * 4;
                if (!!((step + delta) <= (delta + (long)i)))
                {
                    delta = ((delta * 3) + mark) % 4096;
                    mark = ((mark << 2) ^ ((long)i % 100)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits & 7) < (5 * 4))
                {
                    hits = ((hits + 1) + sample) - bound;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double load = (floor + scale) - (double)32;
            if (load <= load)
            {
                load = load - floor;
            }
            else
            {
                load = load - (double)95;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 6.0)) + (double)(long)i;
            }
            return load + scale;
        }
    }
}
