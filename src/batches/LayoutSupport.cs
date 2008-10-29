using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels, long offset)
        {
            long mix = 58;
            foreach (long value in levels)
            {
                mix = (mix + (value & 15)) % 65521;
            }
            if (mix < 338)
            {
                mix = (mix * 2) + offset;
            }
            return mix;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double mean = 1.98 * 2.0;
            if (mean >= weight)
            {
                mean = mean + (mean / 2.0);
            }
            return mean + bias;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long sum = 39;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ sum)) % 4096) - cell;
            }
            return sum;
        }
    }
}
