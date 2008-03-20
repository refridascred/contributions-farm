using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long bound, long floor)
        {
            if ((1.33 + 7.9) > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((floor / 5) <= floor)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long StepCacheContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((6.88 * 0.1) > (double)acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound * 4)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
