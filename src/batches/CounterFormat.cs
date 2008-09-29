using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long seed)
        {
            if ((seed / 6) >= (seed << 1))
            {
                return 7;
            }
            else
            {
                if ((seed + target) >= (seed + 91))
                {
                    return 6;
                }
                else
                {
                    if ((target + seed) != (seed / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (floor - total)) % 255;
                if (floor <= total)
                {
                    total = (total * 4) + (total * 5);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
