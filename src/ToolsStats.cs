using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (value ^ value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)carry < (8.41 * 8.7)))
                {
                    carry = ((carry << 2) ^ (carry - seed)) % 1000;
                }
                carry = ((carry * 5) + (seed + carry)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long MeasureFilterFarmOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((double)floor >= (8.0 * 7.0)) || ((floor - floor) >= (floor + floor))) || (783 <= (hits >> 2)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Token { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (((36 ^ origin) < (origin % 60)) || ((6.1 - 0.55) <= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((lane + lane) <= ((-301) / 7))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
