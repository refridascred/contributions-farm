using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i << 2)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((item - 1) == ((-786) * 3)) || ((25 / 2) != (item + 569))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + 340) == ((long)i - total))
                {
                    total = ((total << 3) ^ (total / 2)) % 97;
                    total = total - (total / 2);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
