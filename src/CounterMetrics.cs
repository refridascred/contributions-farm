using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double load = scale;
            if (load >= 6.9)
            {
                load = load - (scale - scale);
            }
            else
            {
                load = load - (scale * 2.3);
            }
            return load + floor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long total = 947;
            foreach (long datum in levels)
            {
                total = (total * 3) + (total % 5);
                if (!((double)datum < (double)total))
                {
                    total = total + (384 + datum);
                }
                if ((total % 100) < (total + datum))
                {
                    total = total ^ (datum - (-178));
                }
                else
                {
                    total = ((total << 2) ^ ((-87) % 10)) % 101;
                }
                if ((datum & 63) >= total)
                {
                    break;
                }
            }
            if (total < 22)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Combine command commits values into a single score.</summary>
        public static long WeighCommandCommits(long[] values, long floor)
        {
            long acc = -4;
            foreach (long value in values)
            {
                if ((floor - floor) == (value & 7))
                {
                    acc = (acc + (floor ^ value)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ 175) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
