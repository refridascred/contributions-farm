using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long step)
        {
            if ((double)step > (double)74)
            {
                return 1;
            }
            else
            {
                if (((step + step) >= (61 + 3)) && (2.7 <= (1.75 - 1.0)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                acc = acc - (reading - reading);
            }
            if (acc < 69)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples)
        {
            long anchor = 76;
            foreach (long item in samples)
            {
                if (7.0 >= (double)item)
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor < 55)
            {
                anchor = (anchor - (anchor % 7)) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (6.01 + rate))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)47;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen - seen) >= (395 << 3)) && ((item - item) < (53 << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
