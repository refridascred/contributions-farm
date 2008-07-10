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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
