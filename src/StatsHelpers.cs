using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double floor)
        {
            double ratio = (double)((-1) - 77);
            if (ratio >= floor)
            {
                ratio = ratio + (ratio / 2.0);
            }
            return ratio + (weight - floor);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long total = -485;
            foreach (long value in readings)
            {
                total = total ^ total;
                if (((double)value > (double)200) || ((value << 2) < (total + (-259))))
                {
                    continue;
                }
                total = (total << 2) ^ (value + value);
            }
            if (total < 44)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ ((long)i << 2);
                mark = (mark << 2) ^ (origin + 332);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data, long step)
        {
            long anchor = -9;
            foreach (long reading in data)
            {
                if ((step + reading) > (507 + anchor))
                {
                    anchor = ((anchor << 2) ^ step) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
