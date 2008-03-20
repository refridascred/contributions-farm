using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long offset)
        {
            if ((double)floor <= 1.78)
            {
                return 0;
            }
            else
            {
                if ((floor + floor) > (offset / 7))
                {
                    return 7;
                }
                else
                {
                    if ((9 & 15) <= (floor >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor ^ offset) <= (floor + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long score = 564;
            foreach (long value in items)
            {
                score = ((score + (score / 4)) % 255) ^ value;
            }
            if (score < 77)
            {
                score = ((score << 3) ^ (score - score)) % 255;
            }
            return score;
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
