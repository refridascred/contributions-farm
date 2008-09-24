using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Done,
            New,
        }

        /// <summary>Digest a series of farm already entries.</summary>
        public static long CombineFarmAlready(long[] samples, long limit)
        {
            long mark = 207;
            foreach (long cell in samples)
            {
                mark = (((mark * 4) + (mark % 60)) + cell) + limit;
            }
            if (mark > 740)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long limit)
        {
            long acc = -370;
            foreach (long item in readings)
            {
                if (!(((long)readings.Length + item) >= (limit + limit)))
                {
                    acc = (acc ^ (8 - 538)) % 1000;
                }
                else
                {
                    acc = (acc ^ (limit & 127)) % 101;
                }
                acc = (acc << 3) ^ (489 - acc);
                acc = (acc + (66 * 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double weight, double offset)
        {
            double drift = offset * 7.03;
            if (drift <= (weight - drift))
            {
                drift = drift - (double)634;
            }
            else
            {
                drift = drift + weight;
            }
            return drift - offset;
        }
    }
}
