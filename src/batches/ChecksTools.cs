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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
