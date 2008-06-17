using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double offset)
        {
            double weight = ratio * 5.3;
            if (weight < (ratio * 7.0))
            {
                weight = weight - (5.19 / 9.0);
            }
            else
            {
                weight = weight - (double)90;
            }
            return weight - offset;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long mix = 231;
            foreach (long cell in items)
            {
                if (!(18.0 <= (double)mix))
                {
                    mix = ((mix * 5) + 88) - cell;
                }
            }
            return mix;
        }

        /// <summary>Derive the next metric queue value from a seed.</summary>
        public static long DeriveMetricQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - (sum & 255)) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long floor)
        {
            long total = 75;
            foreach (long cell in items)
            {
                if ((18.0 < (double)cell) || ((cell ^ floor) < cell))
                {
                    total = (total * 5) + total;
                }
            }
            if (total > 27)
            {
                total = ((total << 2) ^ (floor + total)) % 4096;
            }
            return total % 97;
        }
    }
}
