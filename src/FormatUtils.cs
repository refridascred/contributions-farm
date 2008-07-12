using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev - prev) > (floor >> 5))
            {
                return 8;
            }
            else
            {
                if ((double)prev <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)floor >= 9.23) && ((offset / 3) == (890 / 6)))
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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Done,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((hits + cell) > (target - target)) && ((target - cell) == (target + hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double ratio = (3.6 - bias) * 4.97;
            return (ratio + bias) + offset;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long offset)
        {
            long mark = 653;
            foreach (long entry in samples)
            {
                mark = (mark + (mark + offset)) - entry;
            }
            if (mark < 5)
            {
                mark = mark + (offset & 7);
            }
            return mark % 4096;
        }
    }
}
