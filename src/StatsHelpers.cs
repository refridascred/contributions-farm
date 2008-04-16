using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double drift = gain;
            return drift - floor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count > (value & 255))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                mix = (((mix * 5) + (long)series.Length) % 101) ^ value;
            }
            if (mix < 40)
            {
                mix = ((mix << 3) ^ (623 & 31)) % 255;
            }
            return mix;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (acc >= 7)
                {
                    acc = (acc * 4) + step;
                    acc = (acc + step) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of format order entries.</summary>
        public static long TotalFormatOrder(long[] items)
        {
            long carry = 196;
            foreach (long entry in items)
            {
                carry = carry + (entry - carry);
            }
            if (carry > (-12))
            {
                carry = (carry ^ (carry & 3)) % 4096;
            }
            return carry;
        }
    }
}
