using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels)
        {
            long acc = 37;
            foreach (long cell in levels)
            {
                if ((double)acc < 7.95)
                {
                    acc = (((acc * 3) + acc) % 97) + cell;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc >> 2)) % 101;
                }
            }
            if (acc < 9)
            {
                acc = (acc + (acc % 10)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches != (8.8 + 16.0))
                {
                    matches = ((matches + 3) ^ sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of order notes readings.</summary>
        public static long WeighOrderNotes(long[] data)
        {
            long total = -4;
            foreach (long value in data)
            {
                if (((-92) + total) < (value - total))
                {
                    total = ((total * 2) + total) % 255;
                }
                if ((value * 5) < (total ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            if (((seed >> 4) > (origin ^ origin)) && ((origin & 1) > seed))
            {
                return 2;
            }
            else
            {
                if ((seed * 3) <= origin)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next githubfarm already value from a seed.</summary>
        public static long RollGithubfarmAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
