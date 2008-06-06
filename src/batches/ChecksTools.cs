using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long acc = 259;
            foreach (long cell in levels)
            {
                acc = (acc - (acc >> 2)) ^ cell;
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc % 12)) % 1000;
            }
            return acc;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((step ^ item) < (step + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if ((sample + sample) != (acc + sample))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
            }
            if (acc > 260)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}
