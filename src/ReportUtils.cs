using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the profile channel series from a seed.</summary>
        public static long IterateProfileChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound ^ (long)i) == ((long)i + mix))
                {
                    mix = (mix ^ ((long)i * 4)) % 65521;
                    mix = ((mix << 2) ^ (11 % 100)) % 65521;
                }
                else
                {
                    mix = (mix + (bound - (long)i)) % 65521;
                    mix = mix + bound;
                }
                mix = (mix + ((long)i * 5)) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many queue command samples are out of range.</summary>
        public static long MeasureQueueCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 343) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
