using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample / 7) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 4) + (27 + 495);
                acc = (acc - (acc & 127)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate support buffer readings against a bound.</summary>
        public static bool GuardSupportBufferBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Failed,
            Locked,
            Idle,
        }
    }
}
