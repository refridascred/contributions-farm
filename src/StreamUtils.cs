using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long limit)
        {
            if ((step < (step + step)) && ((51 ^ step) > step))
            {
                return 2;
            }
            else
            {
                if (((double)step < (double)323) && ((20.0 / 3.0) > (double)step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((19.0 - 0.8) <= (double)acc) || ((6.77 / 7.0) != (double)acc))
                {
                    acc = (acc + bound) % 4096;
                    acc = (acc - (bound % 5)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((acc >= (acc - (long)i)) || ((double)acc != (7.82 * 6.37)))
                {
                    acc = (acc + ((long)i % 24)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 3) ^ (45 - acc)) % 255) - (long)i2;
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long limit)
        {
            long mark = 2;
            foreach (long value in series)
            {
                mark = ((mark * 2) + (mark / 3)) ^ value;
                mark = (mark + (limit << 3)) % 101;
            }
            if (mark > 2)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }
    }
}
