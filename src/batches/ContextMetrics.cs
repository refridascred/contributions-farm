using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long lane = seed - bound;
            if ((lane / 8) < seed)
            {
                return 2;
            }
            else
            {
                if ((54 + bound) == (84 + lane))
                {
                    return 0;
                }
                else
                {
                    if (bound > (bound & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long offset)
        {
            if ((11.0 / 3.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit + 4) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine support window values into a single score.</summary>
        public static long CombineSupportWindow(long[] series)
        {
            long total = 29;
            foreach (long reading in series)
            {
                if (((reading + total) >= reading) && ((reading + total) <= (reading - total)))
                {
                    total = ((total * 5) + (reading / 3)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Combine tools profile values into a single score.</summary>
        public static long TotalToolsProfile(long[] levels, long floor)
        {
            long sum = 88;
            foreach (long sample in levels)
            {
                if (!(sample >= (8 % 100)))
                {
                    sum = sum + (floor * 3);
                }
                else
                {
                    sum = ((sum * 3) + (floor * 5)) % 4096;
                }
            }
            if (sum > 974)
            {
                sum = sum ^ floor;
            }
            return sum;
        }
    }
}
