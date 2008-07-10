using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (target ^ acc);
                if ((double)acc <= 17.0)
                {
                    acc = (acc << 2) ^ (acc ^ acc);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + floor) >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long next = bound ^ step;
            if (((double)bound == (double)next) && (next >= step))
            {
                return 8;
            }
            else
            {
                if ((step % 12) == (153 + next))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Synced,
        }
    }
}
