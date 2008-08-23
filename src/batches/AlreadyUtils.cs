using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if ((offset * 4) == (limit & 3))
            {
                return 4;
            }
            else
            {
                if ((double)offset <= (0.85 - 5.5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix + (floor + floor)) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate context contributi readings against a bound.</summary>
        public static bool CheckContextContributiBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)0 <= (double)hits)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
